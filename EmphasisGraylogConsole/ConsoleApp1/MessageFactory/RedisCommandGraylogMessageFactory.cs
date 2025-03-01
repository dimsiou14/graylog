using EmphasisGraylogConsole.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmphasisGraylogConsole.MessageFactory
{
    public class RedisCommandGraylogMessageFactory : IGraylogMessageFactory
    {
        public string CreateMessage(object[] parameters)
        {
            var host = (string)parameters[0];
            var service = (string)parameters[1];
            var codeLine = (string)parameters[2];
            var message = (string)parameters[3];
            var redisCommand = (RedisCommandType)parameters[4];
            var secondsToBeExecuted = (int)parameters[5];
            var key = (string)parameters[6];

            RedisCommandGraylogObject redisCommandGraylogObject = new RedisCommandGraylogObject(host, service, codeLine, message, redisCommand, secondsToBeExecuted, key);
            return JsonConvert.SerializeObject(redisCommandGraylogObject);
        }
    }
}
