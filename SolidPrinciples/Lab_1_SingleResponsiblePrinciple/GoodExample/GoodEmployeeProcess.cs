using SolidPrinciples.Lab_1_SingleResponsiblePrincible.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Lab_1_SingleResponsiblePrincible.GoodExample
{
   public class GoodEmployeeProcess:GoodLogerProcess
    {
        GoodEmployeeProcess logger;
        public GoodEmployeeProcess()
        {
            logger = new GoodEmployeeProcess();
        }

        string log;
        public bool InsertEmployee(Employee newEmployee)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                sb.Append(newEmployee.Id);
                sb.AppendLine();
                sb.Append(newEmployee.FirstName);
                sb.AppendLine();
                sb.Append(newEmployee.LastName);

                log = logger.BuildLog(sb.ToString());
                logger.LogFile(@"C:\SolidLog.txt", log);

                log = logger.BuildLog($"Employee insert successfull => {newEmployee.Id}");
                logger.LogFile(@"C:\SolidLog.txt", log);

                return true;
            }
            catch (Exception ex)
            {

                log = logger.BuildLog("Failure Message:" + ex.Message);
                logger.LogFile(@"C:\SolidLog.txt", log);

                return false;

            }
        }

    }
}
