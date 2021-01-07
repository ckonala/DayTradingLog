using Microsoft.VisualStudio.TestTools.UnitTesting;
using DayTradingLog.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTradingLog.Database.Tests
{
    [TestClass()]
    public class Tests
    {
        [TestMethod()]
        public void Checkstocks()
        {
            Stocks stock = new Stocks()
            {
                Quantity = 10,
                TotalPurchasePrice = 10,
                TotalSalePrice = 15
            };

            Assert.AreEqual(10, stock.TotalPurchasePrice,"Wrong Total Purchase Price for Stocks");
            Assert.AreEqual(15, stock.TotalSalePrice,"Wrong Total Sales Price for Stocks");
            Assert.AreEqual(5, stock.TradePL,"Wrong P/L Total for stocks");
        }

        [TestMethod()]
        public void CheckOptions()
        {
            Stocks stock = new Options()
            {
                Quantity = 10,
                TotalPurchasePrice = 10,
                TotalSalePrice = 15
            };

            Assert.AreEqual(10000, stock.TotalPurchasePrice,"Wrong Total Purchase Price for Options");
            Assert.AreEqual(15000, stock.TotalSalePrice,"Wrong Total Sales Price for Options");
            Assert.AreEqual(5000, stock.TradePL, "Wrong P/L Total for Options");
        }

        [TestMethod()]
        public void CheckPremiumStocks()
        {
            Stocks stock = new PremiumStocks()
            {
                Quantity = 10,
                TotalPurchasePrice = 10,
                TotalSalePrice = 15
            };

            Assert.AreEqual(102.65M, stock.TotalPurchasePrice, "Wrong Total Purchase Price for Premium Stocks");
            Assert.AreEqual(152.65M, stock.TotalSalePrice, "Wrong Total Sales Price for Premium Stocks");
            Assert.AreEqual(50.00M, stock.TradePL, "Wrong P/L Total for Premium Stocks");
        }

        [TestMethod()]
        public void CheckOptionsNegativeValue()
        {
            Stocks stock = new Options()
            {
                Quantity = 10,
                TotalPurchasePrice = 10,
                TotalSalePrice = 5
            };

            Assert.AreEqual(10000, stock.TotalPurchasePrice, "Wrong Total Purchase Price for Options using Negative Values");
            Assert.AreEqual(5000, stock.TotalSalePrice, "Wrong Total Sales Price for Options using Negative Values");
            Assert.AreEqual(-5000, stock.TradePL, "Wrong P/L Total for Options using Negative Values");
        }

        [TestMethod()]
        public void CheckPremiumStocksNegativeValue()
        {
            Stocks stock = new PremiumStocks()
            {
                Quantity = 10,
                TotalPurchasePrice = 10,
                TotalSalePrice = 5
            };

            Assert.AreEqual(102.65M, stock.TotalPurchasePrice, "Wrong Total Purchase Price for Premium Stocks using Negative Values");
            Assert.AreEqual(52.65M, stock.TotalSalePrice, "Wrong Total Sales Price for Premium Stocks using Negative Values");
            Assert.AreEqual(-50.00M, stock.TradePL, "Wrong P/L Total for Premium Stocks using Negative Values");
        }

        [TestMethod()]
        public void Logintest()
        {
            LoginDatabase loginDatabase = new LoginDatabase();
            var result = loginDatabase.ValidateLogin("test", "test");
            Assert.IsTrue(result,"Test failed when the credentials are Valid");

            result = loginDatabase.ValidateLogin("test", "test1");
            Assert.IsFalse(result,"Test Failed when the Credentials are Invalid");

        }
    }
}