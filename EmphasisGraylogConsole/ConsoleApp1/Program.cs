using EmphasisGraylogConsole.MessageFactory;
using EmphasisGraylogConsole.Models;
using EmphasisGraylogConsole.Senders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmphasisGraylogConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Definition

            IGraylogMessageFactory sqlMessageFactory = new SqlQueryGraylogMessageFactory();
            IGraylogSender sqlQuerySender = new SqlQueryGraylogSender("http://localhost:12201/gelf/sqlQueries", sqlMessageFactory);

            IGraylogMessageFactory redisMessageFactory = new RedisCommandGraylogMessageFactory();
            IGraylogSender redisCommandSender = new RedisCommandGraylogSender("http://localhost:12201/gelf/redisCommands", redisMessageFactory);

            IGraylogMessageFactory exceptionMessageFactory = new ExceptionGraylogMessageFactory();
            IGraylogSender exceptionSender = new ExceptionGraylogSender("http://localhost:12201/gelf/watchdogExceptions", exceptionMessageFactory);


            // Usage

            string sqlMessage = sqlQuerySender.CreateMessage(new object[] { "host", "service", "codeLine", "message", "SELECT * FROM Users", 10 });
            sqlQuerySender.SendAsync(sqlMessage);

            string redisMessage = redisCommandSender.CreateMessage(new object[] { "host", "service", "codeLine", "message", RedisCommandType.Enqueue, 5 });
            redisCommandSender.SendAsync(redisMessage);

            string exceptionMessage = exceptionSender.CreateMessage(new object[] { "host", "service", "codeLine", "message", new Exception("Null reference exception") });
            exceptionSender.SendAsync(exceptionMessage);
        }
    }
}
