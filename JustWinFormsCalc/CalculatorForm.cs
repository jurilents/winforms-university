using JustWinFormsCalc.CalcWfcServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustWinFormsCalc
{
    public partial class CalculatorForm : Form
    {
        private readonly UserContract _user;

        public CalculatorForm(UserContract user)
        {
            _user = user;
            InitializeComponent();
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            helloOutput.Text = $"Hello, {_user.Name}!";
        }
    }
}
