using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "hello";
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(charArray);
        }
    }
}
