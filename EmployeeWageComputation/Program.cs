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
            Uc1Attendence uc1Attendence = new Uc1Attendence();
            Uc1Attendence.Employee();
            Uc2EmployeeWage uc2EmployeeWage = new Uc2EmployeeWage();
            Uc2EmployeeWage.CalculateWages();
                Console.ReadLine();
        }
    }
}
