using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace PE08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Question 7

            string userString;
            Console.WriteLine("Enter a string: ");
            userString = Console.ReadLine();
            char[] charArray = userString.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(charArray);

            //Question 8

            string userStringQ8;
            Console.WriteLine("Enter a string: ");
            userStringQ8 = Console.ReadLine().ToLower();

            if (userStringQ8.Contains("no") == true)
            {
                userStringQ8.Replace("no", "yes");
            }
            Console.WriteLine(userStringQ8);

        //Question 9
            string unquotedString;
            string[] quotedString;

            Console.WriteLine("Type any string please");
            unquotedString = Console.ReadLine();

            quotedString = unquotedString.Split(' ');

            foreach (string word in quotedString)
            {
                Console.Write("\"{0}\" ", word);
            }
        }

    }
}
