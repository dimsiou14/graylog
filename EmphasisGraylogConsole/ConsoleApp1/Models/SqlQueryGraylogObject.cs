using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmphasisGraylogConsole.Models
{
    public class SqlQueryGraylogObject : BaseGraylogObject
    {
        public SqlQueryGraylogObject(string host, string service, string codeLine, string message, string sqlQuerry, int secondsToBeExecuted)
            : base(host, service, codeLine, message)
        {
            SqlQuery = sqlQuerry;
            SecondsToBeExecuted = secondsToBeExecuted;
        }
        public string SqlQuery { get;set; }
        public int SecondsToBeExecuted { get; set; }
    }
}
