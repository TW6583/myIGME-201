using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//POINTS TAKEN OFF: 16

namespace PE04_Question_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double userNum1, userNum2;

            Console.WriteLine("Enter a number:");
            userNum1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter another number:");
            userNum2 = Convert.ToDouble(Console.ReadLine());

            if (userNum1 > 10 && userNum2 > 10)
            {
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine(userNum1);
                Console.WriteLine(userNum2);
            }
        }
    }
}
