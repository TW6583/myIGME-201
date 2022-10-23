using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest2
{
    //Unit Test 2
    //Timothy Wu
    
    
    //Question 1
    //They switched the code in the getters and setters.
    
    //Corrected code

/*    public class Zoo
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                this.name = value;
            }
        }
    }*/

     //Question 2
     //There is nothing wrong with the code

/*     public sealed class Circus
    {
        public string name;
    }


    static class Program
    {
        static void Main()
        {
            Circus myCircus = new Circus();
            
        }
    }
*/


    internal class Program
    {
        static void Main(string[] args)
        {
            //Question 3

            SortedList<(double, double, double), double> zValue = new SortedList<(double, double, double), double>();

            for (double w = -2; w <= 0; w += 0.2)
            {
                for (double y = -1; y <= 1; y += 0.1)
                {
                    for (double x = 0; x <= 4; x += 0.1)
                    {
                        double yExponent = Math.Round(Math.Pow(y, 3), 2);
                        double xExponent = Math.Round(Math.Pow(x, 2), 2);
                        double wExponent = Math.Round(Math.Pow(w, 1), 2);

                        zValue[(wExponent, yExponent, xExponent)] = Math.Round((4 * yExponent) + (2 * xExponent) - (8 * wExponent) + 7, 3);
                    }
                }
            }



        }
    }
}
