
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    public static class Actions
    {
        public static Result InfoLogg()
        {
            Logger logger = Logger.GetLogger();

            LoggInfo loggInfo = new LoggInfo(DateTime.Now, "Info", "Start method: InfoLogg");

            logger.AddLogg(loggInfo);

            return new Result(true);
        }
        public static BusinessException WarningLogg()
        {
            return new BusinessException("Skipped logic in method");
        }

        public static void ErrorLogg()
        {
            throw new Exception("I broke a logic");
        }
    }
}
