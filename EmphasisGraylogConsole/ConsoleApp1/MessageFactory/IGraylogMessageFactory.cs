using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmphasisGraylogConsole.MessageFactory
{
    public interface IGraylogMessageFactory
    {
        string CreateMessage(object[] parameters);
    }
}
