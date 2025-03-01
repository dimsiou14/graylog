using EmphasisGraylogConsole.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmphasisGraylogConsole.MessageFactory
{
    public class SqlQueryGraylogMessageFactory : IGraylogMessageFactory
    {
        public string CreateMessage(object[] parameters)
        {
            var host = (string)parameters[0];
            var service = (string)parameters[1];
            var codeLine = (string)parameters[2];
            var message = (string)parameters[3];
            var sqlQuery = (string)parameters[4];
            var secondsToBeExecuted = (int)parameters[5];

            SqlQueryGraylogObject sqlQueryGraylogObject = new SqlQueryGraylogObject(host, service, codeLine, message, sqlQuery, secondsToBeExecuted);
            return JsonConvert.SerializeObject(sqlQueryGraylogObject);
        }
    }
}
