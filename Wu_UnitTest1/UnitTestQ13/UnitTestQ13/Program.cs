using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitTestQ13
{
    internal class Program
    {
        struct employee
        {
            public string sName;
            public double dSalary;
        }
        static bool GiveRaise(ref employee employeeOne)
        {
            if (employeeOne.sName == employeeOne.sName)
            {
                employeeOne.dSalary += 19999.99;
                return true;
            }
            else
            {
                return false;
            }
        }


        static void Main(string[] args)
        {


            employee employeeOne;
            employeeOne.dSalary = 30000.00;

            Console.WriteLine("Enter your name: ");
            employeeOne.sName = Console.ReadLine();
            GiveRaise(ref employeeOne);


            Console.WriteLine("Congratulations " + employeeOne.sName + ", you got a raise. Your new salary is: $" + employeeOne.dSalary);
        }


    }
}
