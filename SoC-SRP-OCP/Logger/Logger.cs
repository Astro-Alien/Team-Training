using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace LoggingSystem
{

    public class Logger
    {
        protected readonly Formatter _Messageformatter;

        public Logger(Formatter formatter)
        {
            _Messageformatter = formatter;
        }

        public void LogMessage(String message) {
            Console.WriteLine(_Messageformatter.Format(message));
        }

    }
}
