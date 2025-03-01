using EmphasisGraylogConsole.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmphasisGraylogConsole.MessageFactory
{
    public class ExceptionGraylogMessageFactory : IGraylogMessageFactory
    {
        public string CreateMessage(object[] parameters)
        {
            var host = (string)parameters[0];
            var service = (string)parameters[1];
            var codeLine = (string)parameters[2];
            var message = (string)parameters[3];
            var exception = (Exception)parameters[4];

            ExceptionGraylogObject exceptionGraylogObject = new ExceptionGraylogObject(host, service, codeLine, message, exception.Message);
            return JsonConvert.SerializeObject(exceptionGraylogObject);
        }
    }
}
