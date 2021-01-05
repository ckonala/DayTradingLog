using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DayTradingLog.Classes;
using DayTradingLog.Database;

namespace DayTradingLog.Views
{
    public partial class AddTradeForm : Form
    {
        public AddTradeForm()
        {
            InitializeComponent();
            tradeTypeComboBox.DataSource = ComboBoxItems.TradeTypeIList;
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
                    Queries.InsertTrade(stocks);
                }
                else if(tradeTypeComboBox.SelectedIndex == 1)
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
                    Queries.InsertTrade(stocks);
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
                    Queries.InsertTrade(stocks);
                }

            }
        }

        private bool ValidateControls()
        {
            bool result = false;
            int qty;
            Decimal purchasePrice,saleprice;
            if(!(tickerTextBox.Text is null) && tickerTextBox.Text.Length > 0)
            {
                if (!(tradeDateTimePicker.Value > DateTime.Now))
                {
                    if (!(qtyTextBox.Text is null) && qtyTextBox.Text.Length > 0 && int.TryParse(qtyTextBox.Text,out qty))
                    {
                        if (!(purchasePriceTextBox.Text is null) && purchasePriceTextBox.Text.Length > 0 &&
                            decimal.TryParse(purchasePriceTextBox.Text,out purchasePrice))
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
