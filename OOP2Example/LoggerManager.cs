using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2Example
{
    public class LoggerManager
    {
        public void Logger(ILoggerService loggerManager)
        {
            loggerManager.Log();
        }

        public void LoggerList(List<ILoggerService> loggerManagers)
        {
            foreach (var loger in loggerManagers)
            {
                loger.Log();
            }
        }
    }
}
