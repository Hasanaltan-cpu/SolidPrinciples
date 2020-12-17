using SolidPrinciples.Lab_1_SingleResponsiblePrincible.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Lab_1_SingleResponsiblePrincible.BadExample
{
   public class BadEmployeeProcess
    {
        public void InsertEmployee(Employee newEmployee) // That is insert of Employee our 1 work on the Theorical example.
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                #region 1.Process=>First Job Adding New Worker
                sb.Append(newEmployee.Id);
                sb.AppendLine();
                sb.Append(newEmployee.FirstName);
                sb.AppendLine();
                sb.Append(newEmployee.LastName);
                sb.AppendLine();
                sb.Append(newEmployee.HireDate);
                File.WriteAllText(@"C:\SolidEmployeeData.txt", sb.ToString());
                #endregion

                
            }
            catch (Exception ex)
            {
                #region 2.Process=>When the failure of this first process
                sb = new StringBuilder();
                sb.Append("Failure Date:");
                sb.Append(DateTime.Now.ToString());
                sb.AppendLine();
                sb.Append("Failure Message:");
                sb.Append(ex.Message);
                File.WriteAllText(@"C:\SolidLog.txt", ToString());
                System.Windows.Forms.MessageBox.Show("Opps..Warning Failured");
                #endregion
                
            }
        }
    }
}
