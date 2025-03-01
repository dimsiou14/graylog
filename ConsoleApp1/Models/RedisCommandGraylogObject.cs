using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmphasisGraylogConsole.Models
{
    public class RedisCommandGraylogObject : BaseGraylogObject
    {
        public RedisCommandGraylogObject(string host, string service, string codeLine, string message, RedisCommandType redisCommand, int secondsToBeExecuted, string key)
            : base(host, service, codeLine, message)
        {
            RedisCommand = redisCommand;
            SecondsToBeExecuted = secondsToBeExecuted;
            Key = key;
        }
        public RedisCommandType RedisCommand { get; set; }
        public string RedisCommandName => Enum.GetName(typeof(RedisCommandType), RedisCommand);
        public int SecondsToBeExecuted { get; set; }
        public string Key { get; set; }
    }

    public enum RedisCommandType
    {
        Enqueue,
        Dequeue
    }
}
