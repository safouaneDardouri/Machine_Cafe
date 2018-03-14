using DotNetTN.Connector.SQL;
using DotNetTN.Connector.SQL.Entities;
using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.core
{
    public class Base
    {
        public static string ConnectionString = "server=localhost;Database=CoffeeMachine;Uid=root;Pwd=";

        public static SqlClient GetInstance()
        {
            var d = new Config()
            {
                ConnectionString = ConnectionString,
                DbType = DbType.MySql,
                IsAutoCloseConnection = true
            };
            SqlClient db = new SqlClient(d);

            return db;
        }
    }
}