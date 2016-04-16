using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Szerver.Models
{
    public class Login
    {
        private OracleConnection _Connection;

        private OracleCommand _Command;

        public Login()
        {
            _Connection = new OracleConnection(Constants.CONNECTIONDETAILS);
            _Connection.Open();
            _Command = new OracleCommand();
            _Command.Connection = _Connection;
            _Command.CommandType = System.Data.CommandType.Text;
        }

        public string RunCommand(string Command)
        {
            _Command.CommandText = Command;
            OracleDataReader DataReader = _Command.ExecuteReader();
            DataReader.Read();
            //GetValue(0) => az elso sort teriti
            string Response = DataReader.GetValue(0).ToString();
            return Response;
        }
    }
}