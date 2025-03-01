using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmphasisGraylogConsole.Models
{
    public class BaseGraylogObject
    {
        public BaseGraylogObject(string host, string service, string codeLine, string message)
        {
            Host = host;
            Service = service;
            CodeLine = codeLine;
            Message = message;

        }
        public string Host { get; set; }
        public string Service { get; set; }
        public string CodeLine { get; set; }
        public string Message { get; set; }

    }
}
