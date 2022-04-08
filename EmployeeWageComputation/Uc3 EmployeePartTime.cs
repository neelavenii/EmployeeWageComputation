using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class Uc3EmployeePartTime
    {
        public static void EmployeeWage()
        {
            int isFullTime = 1, isPartTime = 2, empRatePerHr = 20, empHrs = 0, empWage = 0;
            Random random = new Random();

            int empCheck = random.Next(0, 3);
            if (empCheck == isFullTime)
            {
                empHrs = 8;
            }
            else if (empCheck == isPartTime)
            {

                empHrs = 4;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * empRatePerHr;
            Console.WriteLine("empWage:" + empWage);
        }
    }
}


