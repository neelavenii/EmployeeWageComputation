using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class Uc2EmployeeWage
    {
        public static void CalculateWages()
        {
            int isFullTime = 1, empRatePerHr = 20, empHrs = 0, empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            //selection statement
            if (empCheck == isFullTime)
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
