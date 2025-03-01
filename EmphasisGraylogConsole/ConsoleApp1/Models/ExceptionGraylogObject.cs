using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmphasisGraylogConsole.Models
{
    public class ExceptionGraylogObject : BaseGraylogObject
    {
        public ExceptionGraylogObject(string host, string service, string codeLine, string message, string exceptionMessage)
            : base(host, service, codeLine, message)
        {
           ExceptionMessage = exceptionMessage;
        }
        public string ExceptionMessage { get; set; }
    }
}
