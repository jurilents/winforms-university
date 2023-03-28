using JustWinFormsCalc.JustWcfServiceCalc.Clients.Auth;
using JustWinFormsCalc.JustWcfServiceCalc.Clients.Calculator;
using System;
using System.Windows.Forms;

namespace JustWinFormsCalc
{
    public partial class CalculatorForm : Form
    {
        private readonly UserContract _user;
        private const char AddOperator = '+';
        private const char SubOperator = '−';
        private const char MulOperator = '∗';
        private const char DivOperator = '÷';

        public CalculatorForm(UserContract user)
        {
            _user = user;
            InitializeComponent();
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            helloOutput.Text = $"Hello, {_user.Name}!";
        }

        private void button1_Click(object sender, EventArgs e) => AppendNumber(1);
        private void button2_Click(object sender, EventArgs e) => AppendNumber(2);
        private void button3_Click(object sender, EventArgs e) => AppendNumber(3);
        private void button4_Click(object sender, EventArgs e) => AppendNumber(4);
        private void button5_Click(object sender, EventArgs e) => AppendNumber(5);
        private void button6_Click(object sender, EventArgs e) => AppendNumber(6);
        private void button7_Click(object sender, EventArgs e) => AppendNumber(7);
        private void button8_Click(object sender, EventArgs e) => AppendNumber(8);
        private void button9_Click(object sender, EventArgs e) => AppendNumber(9);
        private void button0_Click(object sender, EventArgs e) => AppendNumber(0);

        private void buttonAdd_Click(object sender, EventArgs e) => ApplyOperator(AddOperator);
        private void buttonSubstract_Click(object sender, EventArgs e) => ApplyOperator(SubOperator);
        private void buttonMultiply_Click(object sender, EventArgs e) => ApplyOperator(MulOperator);
        private void buttonDivide_Click(object sender, EventArgs e) => ApplyOperator(DivOperator);

        private void reset_Click(object sender, EventArgs e)
        {
            prevValue.Text = "calculator";
            numberField.Value = 0;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            var calcClient = new CalculatorServiceClient();
            var temp = prevValue.Text.Split(' ');
            var @operator = temp[1][0];
            var payload = new CalcContract
            {
                Token = _user.Token,
                A = decimal.Parse(temp[0]),
                B = numberField.Value,
            };

            var response = @operator switch
            {
                AddOperator => calcClient.Add(payload),
                SubOperator => calcClient.Substract(payload),
                MulOperator => calcClient.Multiply(payload),
                DivOperator => calcClient.Divide(payload),
            };

            if (response.Success)
            {
                prevValue.Text = $"result = {response.Result}";
                numberField.Value = response.Result;
            }
            else
            {
                prevValue.Text = response.Message;
            }
        }

        private void AppendNumber(int num)
        {
            numberField.Value = numberField.Value == 0
                ? num
                : (numberField.Value * 10) + num;
        }

        private void ApplyOperator(char @operator)
        {
            prevValue.Text = $"{numberField.Value} {@operator} ...";
            numberField.Value = 0;
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            var loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }
    }
}
