using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using Newtonsoft.Json;
using System.IO;
using System.Text;

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
            //DataReader.Read();
            return Serialize(DataReader);
        }


        private string Serialize(OracleDataReader _OracleDataReader)
        {
            StringBuilder _StringBuilder = new StringBuilder();
            StringWriter _StringWriter = new StringWriter(_StringBuilder);

            using (JsonWriter jsonWriter = new JsonTextWriter(_StringWriter))
            {
                jsonWriter.WriteStartArray();

                while (_OracleDataReader.Read())
                {
                    jsonWriter.WriteStartObject();

                    int fields = _OracleDataReader.FieldCount;

                    for (int i = 0; i < fields; i++)
                    {
                        jsonWriter.WritePropertyName(_OracleDataReader.GetName(i));
                        jsonWriter.WriteValue(_OracleDataReader[i]);
                    }

                    jsonWriter.WriteEndObject();
                }

                jsonWriter.WriteEndArray();
            }

            return _StringBuilder.ToString();
        }

    }
}