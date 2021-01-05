using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DayTradingLog.Database;
using MySql.Data.MySqlClient;

namespace DayTradingLog
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Stocks stocks = new Options();
            stocks.PurchasePrice = stocks.TotalPurchasePrice = .68M;
            var hh = stocks.TotalPurchasePrice;
            var h1h = stocks.PurchasePrice;
            var ee3 = stocks.TradeType;

            Stocks stocks1 = new Stocks();
            stocks1.PurchasePrice = stocks1.TotalPurchasePrice = 56.00M;
            var ee = stocks1.TotalPurchasePrice;
            var ee1 = stocks1.PurchasePrice;
            var ee2 = stocks1.TradeType;

            Stocks stocks2 = new PremiumStocks();
            stocks2.Quantity = 100;
            stocks2.PurchasePrice = stocks2.TotalPurchasePrice = 1.00M;
            var ss = stocks2.TotalPurchasePrice;
            var ss1 = stocks2.PurchasePrice;
            var ee4 = stocks2.TradeType;

            //remove this late and uncomment the code

            this.Hide();
            MainMenu mainmenu = new MainMenu();
            mainmenu.Show(this);


            //if (!(userNameTextBox.Text is null) && userNameTextBox.Text.Length > 0)
            //{
            //    if (!(passwordTextBox.Text is null) && passwordTextBox.Text.Length > 0)
            //    {
            //        LoginDatabase login = new LoginDatabase();
            //        if (login.ValidateLogin(userNameTextBox.Text, passwordTextBox.Text))
            //        {
            //            this.Hide();
            //            MainMenu mainmenu = new MainMenu();
            //            mainmenu.Show(this);
            //        }
            //        else
            //        {
            //            MessageBox.Show("Username or Password is incorrect", "Error", MessageBoxButtons.OK);
            //            userNameTextBox.Clear();
            //            passwordTextBox.Clear();
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Password Field is empty", "Error", MessageBoxButtons.OK);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("UserName Field is empty", "Error", MessageBoxButtons.OK);
            //}
        }
    }
}
