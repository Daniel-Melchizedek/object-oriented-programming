using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Common
{
    public static class LoggingService
    {
        /// <summary>
        /// Write to console temporarily
        /// </summary>
        public static void WriteToFile(List<ILoggable> ItemsToLog)
        {
            StringBuilder sb = new StringBuilder();
            foreach(var item in ItemsToLog)
            {
                sb.AppendLine($"{item.Log()}");
            }
            Console.WriteLine( sb.ToString() );
            //File.WriteAllText("C:\\Users\\daniel.thomas.samuel\\OneDrive - Accenture\\Documents\\OOP_Fundamentals\\Introduction\\Introduction\\LogFiles\\Log1.txt",sb.ToString());
        }
    }
}
