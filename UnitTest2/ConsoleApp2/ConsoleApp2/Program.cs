using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Question 12

            SortedList<string, DateTime> friendBirthday = new SortedList<string, DateTime>();
            string[] dateValue = { "07-22-2000" };
            string pattern = "MM-dd-yyyy";
            DateTime parsedDate;

            foreach (string date in dateValue)
            {
                if (DateTime.TryParseExact(date, pattern, null, System.Globalization.DateTimeStyles.None, out parsedDate))
                {
                    Console.WriteLine("Converted '{0}' to {1:d}.", date, parsedDate);
                }
                else
                {
                    Console.WriteLine("Unable to convert '{0]' to a date and time");
                }
            }

            //Question 13

            MyClass objectA = new MyClass();
            MyClass objectB;

            objectA.Name += "Tim";

            objectB = objectA;

            Console.WriteLine(objectB.Name);



        }
    }

    //Question 13

    public class MyClass
    {
        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                name = value;
            }
        }
    }

}
