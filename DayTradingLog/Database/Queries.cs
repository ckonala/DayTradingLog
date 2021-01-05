using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DayTradingLog.Database
{
    class Queries:Helper
    {
        private Stocks stocks { get; set; }

        public Queries(Stocks stocks)
        {
            this.stocks = stocks;
        }

        public static int InsertTickerSymbol(Stocks stocks)
        {
            using (MySqlConnection connection = new MySqlConnection(GetRDSConnectionString()))
            {
                connection.Open();

                var result = 0;
                var exists = $"select TickerID from Ticker where Ticker = @tickersymbol";
                using var existscmd = new MySqlCommand(exists, connection);
                existscmd.Parameters.AddWithValue("@tickersymbol", stocks.TickerSymbol.ToUpper());
                existscmd.Prepare();
                var existsresult = existscmd.ExecuteScalar();

                if (existsresult is null)
                {
                    var sql =
                        "INSERT INTO Ticker(Ticker,TickerDesc) VALUES(@ticker, @tickerdesc); select last_insert_id();";

                    using var cmd = new MySqlCommand(sql, connection);

                    cmd.Parameters.AddWithValue("@ticker", stocks.TickerSymbol.ToUpper());
                    cmd.Parameters.AddWithValue("@tickerdesc", stocks.TickerDesc);
                    cmd.Prepare();

                    result = Convert.ToInt32(cmd.ExecuteScalar());
                }
                else
                {
                    var sql =
                        "Update Ticker Set Ticker=@ticker,TickerDesc=@tickerdesc Where TickerID=@tickerid";

                    using var cmd = new MySqlCommand(sql, connection);

                    cmd.Parameters.AddWithValue("@ticker", stocks.TickerSymbol.ToUpper());
                    cmd.Parameters.AddWithValue("@tickerdesc", stocks.TickerDesc);
                    cmd.Parameters.AddWithValue("@tickerid", Convert.ToInt32(existsresult));
                    cmd.Prepare();
                    cmd.ExecuteScalar();
                    result = Convert.ToInt32(existsresult);

                }

                return result;
            }
        }

        public static void InsertTrade(Stocks stocks, Login login)
        {
            using (MySqlConnection connection = new MySqlConnection(GetRDSConnectionString()))
            {
                connection.Open();
                var stockID = InsertTickerSymbol(stocks);

                var sql = "INSERT INTO TradeLog(TickerID,TradeDate,TradeQty,TradePurchase,Tradesold,TradeTotalPurchasePrice,TradeTotalSalePrice,TradeType,TradePL,User) " +
                          "VALUES(@TickerID, @TradeDate, @TradeQty, @TradePurchase, @Tradesold, @TradeTotalPurchasePrice, @TradeTotalSalePrice, @TradeType,@TradePL,@User); select last_insert_id();";

                using var cmd = new MySqlCommand(sql, connection);

                cmd.Parameters.AddWithValue("@TickerID", stockID);
                cmd.Parameters.AddWithValue("@TradeDate", stocks.DateofTrade);
                cmd.Parameters.AddWithValue("@TradeQty", stocks.Quantity);
                cmd.Parameters.AddWithValue("@TradePurchase", stocks.PurchasePrice);
                cmd.Parameters.AddWithValue("@Tradesold", stocks.SalePrice);
                cmd.Parameters.AddWithValue("@TradeTotalPurchasePrice", stocks.TotalPurchasePrice);
                cmd.Parameters.AddWithValue("@TradeTotalSalePrice", stocks.TotalSalePrice);
                cmd.Parameters.AddWithValue("@TradeType", stocks.TradeType);
                cmd.Parameters.AddWithValue("@TradePL", stocks.TradePL);
                cmd.Parameters.AddWithValue("@User", login.UserID);
                cmd.Prepare();
                cmd.ExecuteScalar();
            }

        }

        public static DataTable GetTable(Login login)
        {
            using (MySqlConnection connection = new MySqlConnection(GetRDSConnectionString()))
            {
                connection.Open();
               
                var sql = " SELECT TradeLogID,Ticker.TickerID,TradeTypeID,TradeDate,Ticker,TickerDesc,TradeQty,TradePurchase,Tradesold,TradeTotalPurchasePrice,TradeTotalSalePrice,TradePL,TradeType.TradeType " +
                          "FROM Stocks.TradeLog , Stocks.Ticker,Stocks.TradeType" +
                          " where TradeLog.User=@user and TradeLog.TickerID = Ticker.TickerID and TradeLog.TradeType = TradeType.TradeTypeID " +
                          "order by TradeDate Desc;";

                using var cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@user", login.UserID);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
        }

        public static decimal GetTodaysPL(Login login)
        {
            using (MySqlConnection connection = new MySqlConnection(GetRDSConnectionString()))
            {
                connection.Open();
                using var cmd = new MySqlCommand("TodaysPL", connection);
                cmd.Parameters.Add(new MySqlParameter("@Username", login.UserID));
                cmd.CommandType = CommandType.StoredProcedure;
                var result = cmd.ExecuteScalar();
                return decimal.Parse(result.ToString());
            }

        }

        public static decimal GetCumilativePL(Login login)
        {
            using (MySqlConnection connection = new MySqlConnection(GetRDSConnectionString()))
            {
                connection.Open();
                using var cmd = new MySqlCommand("CumilativePL", connection);
                cmd.Parameters.Add(new MySqlParameter("@Username", login.UserID));
                cmd.CommandType = CommandType.StoredProcedure;
                var result = cmd.ExecuteScalar();
                return decimal.Parse(result.ToString());
            }

        }
    }
}
