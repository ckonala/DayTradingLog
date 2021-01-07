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

            Assert.AreEqual(10, stock.TotalPurchasePrice);
            Assert.AreEqual(15, stock.TotalSalePrice);
            Assert.AreEqual(5, stock.TradePL);
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

            Assert.AreEqual(10000, stock.TotalPurchasePrice);
            Assert.AreEqual(15000, stock.TotalSalePrice);
            Assert.AreEqual(5000, stock.TradePL);
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

            Assert.AreEqual(102.65M, stock.TotalPurchasePrice);
            Assert.AreEqual(152.65M, stock.TotalSalePrice);
            Assert.AreEqual(50.00M, stock.TradePL);
        }

        [TestMethod()]
        public void CheckOptionsNegitiveValue()
        {
            Stocks stock = new Options()
            {
                Quantity = 10,
                TotalPurchasePrice = 10,
                TotalSalePrice = 5
            };

            Assert.AreEqual(10000, stock.TotalPurchasePrice);
            Assert.AreEqual(5000, stock.TotalSalePrice);
            Assert.AreEqual(-5000, stock.TradePL);
        }

        [TestMethod()]
        public void CheckPremiumStocksNegitiveValue()
        {
            Stocks stock = new PremiumStocks()
            {
                Quantity = 10,
                TotalPurchasePrice = 10,
                TotalSalePrice = 5
            };

            Assert.AreEqual(102.65M, stock.TotalPurchasePrice);
            Assert.AreEqual(52.65M, stock.TotalSalePrice);
            Assert.AreEqual(-50.00M, stock.TradePL);
        }

        [TestMethod()]
        public void Logintest()
        {
            LoginDatabase loginDatabase = new LoginDatabase();
            var result = loginDatabase.ValidateLogin("test", "test");
            Assert.IsTrue(result);

            result = loginDatabase.ValidateLogin("test", "test1");
            Assert.IsFalse(result);

        }
    }
}