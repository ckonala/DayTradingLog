using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DayTradingLog.Classes;
using DayTradingLog.Database;

namespace DayTradingLog.Views
{
    public partial class EditTradeForm : Form
    {

        private Login Login { get; set; }

        private DataRowView DataRowView { get; set; }

        private readonly MainMenu mainmenuForm;


        public EditTradeForm(Login login, MainMenu mainmenuForm, DataRowView dataRowView)
        {
            InitializeComponent();
            this.Login = login;
            tradeTypeComboBox.DataSource = ComboBoxItems.TradeTypeIList;
            this.mainmenuForm = mainmenuForm;
            this.DataRowView = dataRowView;
            FillEditForm();
        }

        public void FillEditForm()
        {
            tickerTextBox.Text = DataRowView.Row.ItemArray[4].ToString();
            tickerDescTextBox.Text = DataRowView.Row.ItemArray[5].ToString();
            tradeDateTimePicker.Value = DateTime.Parse(DataRowView.Row.ItemArray[3].ToString());
            qtyTextBox.Text = DataRowView.Row.ItemArray[6].ToString();
            purchasePriceTextBox.Text = DataRowView.Row.ItemArray[7].ToString();
            salePriceTextBox.Text = DataRowView.Row.ItemArray[8].ToString();
            tradeTypeComboBox.SelectedIndex = Int32.Parse(DataRowView.Row.ItemArray[2].ToString());

        }

        private void ClearFields()
        {
            tickerTextBox.Clear();
            tickerDescTextBox.Clear();
            qtyTextBox.Clear();
            purchasePriceTextBox.Clear();
            salePriceTextBox.Clear();
        }

        private void editTradeFormClosing(object sender, FormClosingEventArgs e)
        {
            ClearFields();
            mainmenuForm.RefreshDataGridView();
            this.Hide();
            Owner.Show();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (ValidateControls())
            {
                if (tradeTypeComboBox.SelectedIndex == 0)
                {
                    Stocks stocks = new Stocks()
                    {
                        TickerSymbol = tickerTextBox.Text,
                        TickerDesc = tickerDescTextBox.Text,
                        DateofTrade = tradeDateTimePicker.Value,
                        Quantity = Int32.Parse(qtyTextBox.Text),
                        PurchasePrice = decimal.Parse(purchasePriceTextBox.Text),
                        SalePrice = decimal.Parse(salePriceTextBox.Text),
                        TotalPurchasePrice = Int32.Parse(qtyTextBox.Text) * decimal.Parse(purchasePriceTextBox.Text),
                        TotalSalePrice = Int32.Parse(qtyTextBox.Text) * decimal.Parse(salePriceTextBox.Text),
                        TradeType = tradeTypeComboBox.SelectedIndex
                    };
                    Queries.UpdateTrade(stocks, this.Login,int.Parse(DataRowView.Row.ItemArray[0].ToString()));
                }
                else if (tradeTypeComboBox.SelectedIndex == 1)
                {
                    Stocks stocks = new Options()
                    {
                        TickerSymbol = tickerTextBox.Text,
                        TickerDesc = tickerDescTextBox.Text,
                        DateofTrade = tradeDateTimePicker.Value,
                        Quantity = Int32.Parse(qtyTextBox.Text),
                        PurchasePrice = decimal.Parse(purchasePriceTextBox.Text),
                        SalePrice = decimal.Parse(salePriceTextBox.Text),
                        TotalPurchasePrice = decimal.Parse(purchasePriceTextBox.Text),
                        TotalSalePrice = decimal.Parse(salePriceTextBox.Text),
                        TradeType = tradeTypeComboBox.SelectedIndex
                    };
                    Queries.UpdateTrade(stocks, this.Login, int.Parse(DataRowView.Row.ItemArray[0].ToString()));
                }

                else if (tradeTypeComboBox.SelectedIndex == 2)
                {
                    Stocks stocks = new PremiumStocks()
                    {
                        TickerSymbol = tickerTextBox.Text,
                        TickerDesc = tickerDescTextBox.Text,
                        DateofTrade = tradeDateTimePicker.Value,
                        Quantity = Int32.Parse(qtyTextBox.Text),
                        PurchasePrice = decimal.Parse(purchasePriceTextBox.Text),
                        SalePrice = decimal.Parse(salePriceTextBox.Text),
                        TotalPurchasePrice = decimal.Parse(purchasePriceTextBox.Text),
                        TotalSalePrice = decimal.Parse(salePriceTextBox.Text),
                        TradeType = tradeTypeComboBox.SelectedIndex
                    };
                    Queries.UpdateTrade(stocks, this.Login, int.Parse(DataRowView.Row.ItemArray[0].ToString()));
                }
            }
            ClearFields();
            mainmenuForm.RefreshDataGridView();
            this.Hide();
            Owner.Show();
        }

        private bool ValidateControls()
        {
            bool result = false;
            int qty;
            Decimal purchasePrice, saleprice;
            if (!(tickerTextBox.Text is null) && tickerTextBox.Text.Length > 0)
            {
                if (!(tradeDateTimePicker.Value > DateTime.Now))
                {
                    if (!(qtyTextBox.Text is null) && qtyTextBox.Text.Length > 0 && int.TryParse(qtyTextBox.Text, out qty))
                    {
                        if (!(purchasePriceTextBox.Text is null) && purchasePriceTextBox.Text.Length > 0 &&
                            decimal.TryParse(purchasePriceTextBox.Text, out purchasePrice))
                        {
                            if (!(salePriceTextBox.Text is null) && salePriceTextBox.Text.Length > 0 &&
                                decimal.TryParse(salePriceTextBox.Text, out saleprice))
                            {
                                result = true;

                            }
                            else
                            {
                                MessageBox.Show("Sold At field is empty or not in correct format", "Error", MessageBoxButtons.OK);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Purchase Price field is empty or not in correct format", "Error", MessageBoxButtons.OK);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Trade Quantity Field is empty or not a number", "Error", MessageBoxButtons.OK);
                    }

                }
                else
                {
                    MessageBox.Show("Date and time should be less than or equal to today", "Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Ticker Symbol Field is empty", "Error", MessageBoxButtons.OK);
            }

            return result;

        }
    }
}
