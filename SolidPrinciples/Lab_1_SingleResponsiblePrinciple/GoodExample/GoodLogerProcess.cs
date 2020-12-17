using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Lab_1_SingleResponsiblePrincible.GoodExample
{
    public class GoodLogerProcess
    {
        public void LogFile(string filePath,string log)
        {
            File.WriteAllText(filePath, log);

        }
        public string BuildLog(string information)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Date:");
            sb.Append(DateTime.Now.ToString());
            sb.AppendLine();
            sb.Append("Information:").Append(information);
            return sb.ToString();
        }
    }
}
