using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2Example
{
    public class ExcelLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veriler Excel'e Loglandı");
        }
    }
}
