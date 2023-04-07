using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2Example
{
    public class DataBaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veriler Database'e Loglandı");
        }
    }
}
