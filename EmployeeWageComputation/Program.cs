using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to EmployeeWage Computation");
            while(true)
            {
                Console.WriteLine("Select number :\n1)Attendence\n2)EmployeeWage\n3)EmployeeWagePartTime\n4)SwitchCase\n5)MonthlyWage\n" +
                    "6)WagesForMonth\n7)refractor");
                int option =Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                       
                        Uc1Attendence.Employee();
                        break;
                    case 2:

                        Uc2EmployeeWage.CalculateWages();
                        break;
                    case 3 :

                        Uc3EmployeePartTime.EmployeeWage();
                        break;
                    case 4:

                        Uc4SwitchCase.EmployeeSwitch();
                        break;
                    case 5:

                        Uc5MonthlyWages.MonthlyWages();
                        break;
                    case 6:

                        Uc6WagesForMonth.ForMonth();
                        break;
                    case 7:

                        Uc7Refactor.computeEmpWage();
                        break;
                }
            }
           
                
        }
    }
}
