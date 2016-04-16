using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Szerver.Models
{
    public static class Constants
    {
        public static string USERID = "osztott";
        public static string PASSWORD = "osztott";
        public static string CONNECTIONDETAILS = "Data Source = localhost:1521/xe;User Id =" + Constants.USERID +
                    "; Password = " + Constants.PASSWORD+ ";";
    }
}