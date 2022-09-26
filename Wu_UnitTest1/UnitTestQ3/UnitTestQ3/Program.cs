using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestQ3
{
    internal class Program
    {
        public delegate void roundingFunction(double a);
        static void Main(string[] args)
        {
            double nNumOne;
            double nNumTwo;

            roundingFunction nRound;

            Console.WriteLine("Enter a number: ");
            nNumOne = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter another number: ");
            nNumTwo = Convert.ToDouble(Console.ReadLine());



        }
    }
}
