using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{

    internal class Uc6WagesForMonth
    {
        public static void WagesOfMonth()
        { 
        int empWage = 0, empHrs = 0, totalEmpWage = 0;
        const int FULL_TIME = 1;
        const int PART_TIME = 2;
        const int NUM_OF_WORKING_DAYS = 20;
        const int EMP_RATE_PER_HR = 20;
            const int Max_Working_HRS = 80;
            int WorkingHrs = 0;
            int day = 1;

        Random random = new Random();

            while (day <= NUM_OF_WORKING_DAYS && WorkingHrs<= Max_Working_HRS)
            {
                int empInput = random.Next(0, 3);
                switch (empInput)
                {

                    case FULL_TIME:
                        empHrs = 8;
                        break;
                    case PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * EMP_RATE_PER_HR;
                Console.WriteLine("Daily Wage for day{0} is :{1}", day, empWage);
                totalEmpWage += empWage;
                WorkingHrs += empHrs;
                day++;
            }
            Console.WriteLine("TotalWage for {0} days and working hrs is:{1} and wage is:{2}",day,WorkingHrs,totalEmpWage);
            Console.ReadLine();
        }
    }
}
