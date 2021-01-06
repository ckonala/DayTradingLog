using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DayTradingLog.Database;
using MySql.Data.MySqlClient;

namespace DayTradingLog
{
    public partial class LoginForm : Form
    {
        private Login Login { get; set; }
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (!(userNameTextBox.Text is null) && userNameTextBox.Text.Length > 0)
            {
                if (!(passwordTextBox.Text is null) && passwordTextBox.Text.Length > 0)
                {
                    LoginDatabase login = new LoginDatabase();
                    if (login.ValidateLogin(userNameTextBox.Text, passwordTextBox.Text))
                    {
                        this.Hide();
                        Login loginuserLogin = new Login()
                        {
                            UserID = userNameTextBox.Text
                        };
                        MainMenu mainmenu = new MainMenu(loginuserLogin);
                        mainmenu.Show(this);
                    }
                    else
                    {
                        MessageBox.Show("Username or Password is incorrect", "Error", MessageBoxButtons.OK);
                        userNameTextBox.Clear();
                        passwordTextBox.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Password Field is empty", "Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("UserName Field is empty", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
