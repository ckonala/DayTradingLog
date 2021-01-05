using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTradingLog
{
    public class Stocks
    {
        private const decimal fees = 2.65M;
        public string TickerSymbol { get; set; }

        public string TickerDesc { get; set; }

        public decimal PurchasePrice { get; set; }

        public virtual decimal TotalPurchasePrice { get; set; }

        public DateTime DateofTrade { get; set; }

        public decimal SalePrice { get; set; }

        public virtual decimal TotalSalePrice { get; set; }

        public decimal Fees => fees;

        public int Quantity { get; set; }

        public int TradeType { get; set; }

        public decimal TradePL => (TotalSalePrice - TotalPurchasePrice);

    }

    public class Options : Stocks
    {
        public override decimal TotalPurchasePrice
        {
            get => base.TotalPurchasePrice;
            set => base.TotalPurchasePrice = value* base.Quantity * 100;
        }

        public override decimal TotalSalePrice
        {
            get => base.TotalSalePrice;
            set => base.TotalSalePrice = value* base.Quantity * 100;
        }


    }

    public class PremiumStocks : Stocks
    {
        public override decimal TotalPurchasePrice
        {
            get => base.TotalPurchasePrice;
            set => base.TotalPurchasePrice = (value*base.Quantity) + base.Fees;
        }

        public override decimal TotalSalePrice
        {
            get => base.TotalSalePrice;
            set => base.TotalSalePrice = (value * base.Quantity) + base.Fees;
        }


    }

    public class Login
    {
        public string UserID { get; set; }

        public string Password { get; set; }


    }
}
