using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTD.Capawcino.BusinessLogic;
using DTD.Capawcino.UIExtra;

namespace DTD.Capawcino.App
{
    public partial class LoginForm : BaseForm
    {
        private string UserName => NameTextBox.Text;
        private string Password => PasswordTextBox.Text;

        public LoginForm()
        {
            InitializeComponent();
            try
            {
                CredentialManager credentialManager = new CredentialManager();
                credentialManager.InitialDatabaseSetup();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, @"Database Error");
            }
            
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (new CredentialManager().ValidateUser(UserName, Password))
            {
                var dashboard = new DashboardForm {WindowState = FormWindowState.Maximized};
                dashboard.Show(this);
                Hide();

            }
            else
            {
                MessageBox.Show(@"Invalid Username or Password", @"Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
