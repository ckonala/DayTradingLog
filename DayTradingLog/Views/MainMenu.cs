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
        private BindingSource bindingSource1 = new BindingSource();
        public MainMenu()
        {
            InitializeComponent();
            InitializeDataGridView();

        }

        private void addTradeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddTradeForm addTradeForm = new AddTradeForm();
            addTradeForm.Show(this);
        }

        private void InitializeDataGridView()
        {
            try
            {
                bindingSource1.DataSource = Queries.GetTable();
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
    }
}
