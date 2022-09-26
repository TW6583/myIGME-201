using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace UT1_BugSquash
{
    internal class Program
    {
        //Calculate x^y for y>0 using a recursive function
        static void Main(string[] args)
        {
            string sNumberX;
            string sNumberY;
            int nX;
            // int nY : compile time error, missing a semicolon
            int nY;
            int nAnswer;

            // Console.WriteLine(This program calculates x ^ y.); :compile time error, missing quotes
            Console.WriteLine("This program calculates x ^ y.");

            int Power(int nBase, int nExponent)
            {
                int returnVal = 0;
                int nextVal = 0;

                //the base case for exponents is 0 (x^0 = 1)
                if (nExponent == 0)
                {
                    //return the vase case and do not recurse
                    returnVal = 0;
                }
                else
                {
                    //compute the subsequent values using nExponent-1 to eventuall reach the base case
                    nextVal = Power(nBase, nExponent + 1);

                    //multiply the base with all subsequent values
                    returnVal = nBase * nextVal;
                }
                //returnVal; logical error, needs to return returnVal
                return returnVal;
            }


            do
            {
                Console.Write("Enter a whole number for x: ");
                sNumberX = Console.ReadLine();
            } //while(!int.TryParse(sNumber, out nX)); run time error, sNumber is a string
            while (!int.TryParse(sNumberX, out nX)); 
            do
            {
                Console.Write("Enter a positive whole number for y: ");
                sNumberY = Console.ReadLine();
            } while(int.TryParse(sNumberY, out nY));
            //compute the exponent of the number using a recursive function
            //nAnswer = Power(nX, nY); logical error
            nAnswer = Power(nX, nY);
            Console.WriteLine("{nX} ^ {nY} = {nAnswer}", nX, nY, nAnswer);
        }

    }
}
