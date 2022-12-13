using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;

namespace BankSystem
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            var createdUser = false;
            var username = register_username.Text;
            var password = register_password.Text;
            var repeat_password = register_repeat_password.Text;

            try
            {
                if (password != repeat_password)
                    throw new Exception("The passwords don't match!");
                PersonModel person = new() { Username = username, Password = password };
                MySqlDatabase.CreateUser(person);
                createdUser = true;
            }
            catch (Exception exc)
            {
                register_error_output.Text = exc.Message;
            }
            if (createdUser)
            {
                Hide();
                BankManagment.islogged = true;
            }

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var username = login_username.Text;
            var password = login_password.Text;

            if (MySqlDatabase.CheckUser(username, password))
            {
                Hide();
                BankManagment.islogged = true;
            }
            else login_error_output.Text = "Invalid username or password!";
        }

        private void login_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton.BackColor = Color.LimeGreen;
                loginButton_Click(sender, e);
            }
        }

        private void register_repeat_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                registerButton.BackColor = Color.LimeGreen;
                registerButton_Click(sender, e);
            }
        }
    }
}
