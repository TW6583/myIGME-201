using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestQ12
{
    internal class Program
    {
        static bool GiveRaise(string name, ref double salary)
        {
            if (name == name)
            {
                salary += 19999.99;
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            string sName;
            double dSalary = 30000;

            Console.WriteLine("Enter your name: ");
            sName = Console.ReadLine();
            GiveRaise(sName, ref dSalary);

            Console.WriteLine("Congratulations " + sName + ", you got a raise. Your new salary is: $" + dSalary);
        }
        

    }
}
