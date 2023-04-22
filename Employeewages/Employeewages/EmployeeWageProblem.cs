using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeewages
{
    public class EmployeeWageProblem
       {
            int FULL_TIME = 1;
            int EmpHrs = 0;
            int empWage = 0;
            int EmpRateHrs = 20;
        public void CheckEmployee()
        {
           Random random = new Random();
           int empCheck = random.Next(2);
                if (empCheck == FULL_TIME)
                {
                    EmpHrs = 8;
                }
                else
                {
                    EmpHrs = 0;
                }
             empWage = EmpHrs + EmpRateHrs;
             Console.WriteLine($"Employee Wage is : {empWage}");
        }
    }
}
