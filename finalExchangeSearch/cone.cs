using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
namespace finalExchangeSearch
{
    public class cone
    {
        public static bool login = false;
        public static bool item = false;
        public static bool phEm = false;
        public static string user = "";
        public static string idItem = "";
        public static string gitem = "";
        public static SqlConnection connection = new SqlConnection("Data Source=DESKTOP-8A3O2K0;Initial Catalog=exch;User ID=sa;Password=sa");
    }
}