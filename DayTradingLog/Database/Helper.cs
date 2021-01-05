using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTradingLog.Database
{
    public class Helper
    {
            public static string GetRDSConnectionString()
            {
                return "server=database-1.cib3vsj6typg.us-east-2.rds.amazonaws.com;port=3306;uid=test;pwd=WGUtest;database=Stocks";
            }


            
    }
}
