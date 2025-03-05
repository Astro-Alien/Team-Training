using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingSystem
{
   public class WarningFormatter : Formatter
    {
        public override string Format(string message)
        {
            return $"[Warning]: Time: {DateTime.Now} - Message: {message}";
        }
    }
}
