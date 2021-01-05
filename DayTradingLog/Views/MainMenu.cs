using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DayTradingLog.Database;
using DayTradingLog.Views;

namespace DayTradingLog
{
    public partial class MainMenu : Form
    {
        private Login Login { get; set; }

        private BindingSource bindingSource1 = new BindingSource();
        public MainMenu(Login login)
        {
            InitializeComponent();
            this.Login = login;
            InitializeDataGridView();
            ProfitLossCalc();

        }

        private void addTradeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddTradeForm addTradeForm = new AddTradeForm(this.Login,this);
            addTradeForm.Show(this);
        }

        private void InitializeDataGridView()
        {
            try
            {
                bindingSource1.DataSource = Queries.GetTable(this.Login);
                stockLogDataGridView.DataSource = bindingSource1;
                stockLogDataGridView.Columns["TradeLogID"].Visible = false;
                stockLogDataGridView.Columns["TickerID"].Visible = false;
                stockLogDataGridView.Columns["TradeTypeID"].Visible = false;
                stockLogDataGridView.Columns["TickerDesc"].HeaderText = "Ticker Description";
                stockLogDataGridView.Columns["TradeQty"].HeaderText = "Trade Quantity";
                stockLogDataGridView.Columns["TradePurchase"].HeaderText = "Purchase Price";
                stockLogDataGridView.Columns["Tradesold"].HeaderText = "Sold Price";
                stockLogDataGridView.Columns["TradeTotalPurchasePrice"].HeaderText = "Total Cost Price";
                stockLogDataGridView.Columns["TradeTotalSalePrice"].HeaderText = "Total Sale Price";
            }
            catch (Exception e)
            {
                MessageBox.Show("Cannot Fill Data Grid", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ProfitLossCalc()
        {
            var todaysPl = Queries.GetTodaysPL(Login);
            if (todaysPl > 0)
            {
                todaysPLLabel.Text = todaysPl.ToString();
                todaysPLLabel.ForeColor = Color.DarkGreen;
            }
            else
            {
                todaysPLLabel.Text = todaysPl.ToString();
                todaysPLLabel.ForeColor = Color.Red;
            }

            var cumilativePl = Queries.GetCumilativePL(Login);
            if (cumilativePl > 0)
            {
                cumilativePLLabel.Text = cumilativePl.ToString();
                cumilativePLLabel.ForeColor = Color.DarkGreen;
            }
            else
            {
                cumilativePLLabel.Text = cumilativePl.ToString();
                cumilativePLLabel.ForeColor = Color.Red;
            }
        }

        public void RefreshDataGridView()
        {
            InitializeDataGridView();
            ProfitLossCalc();
        }

        private void mainMenuFormLoad(object sender, EventArgs e)
        {
           
        }

        private void mainMenuFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
