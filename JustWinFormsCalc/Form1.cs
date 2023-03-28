using JustWinFormsCalc.JustWcfServiceCalc.Clients.Auth;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            var authClient = new AuthServiceClient();
            var user = authClient.Authenticate(loginField.Text, passwordField.Text);
            //var user = authClient.Authenticate("admin", "admin");

            if (user == null)
            {
                // log error
                errorOutput.Text = "Login or passowrd is not valid!";
            }
            else
            {
                // open next window
                errorOutput.Text = "Successeed!";
                var calcForm = new CalculatorForm(user);
                this.Hide();
                calcForm.Show();
            }
        }
    }
}
