using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    class Logger
    {
        private static Logger _logger;

        private List<LoggInfo> Loggs { get;set; } = new List<LoggInfo>();

        private Logger()
        {

        }

        public static Logger GetLogger()
        {
            if(_logger == null)
            {
                _logger = new Logger();
            }
            return _logger;
        }

        public void AddLogg(LoggInfo logg)
        {
            Console.WriteLine(logg.ToString() + "\n");
            Loggs.Add(logg);
        }
        public List<LoggInfo> GetLoggs()
        {
            return Loggs;
        }
    }
}
