﻿using System;
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
            byte byteVal;
            short shortVal = -556;
            byteVal = checked((byte)shortVal);
            Console.WriteLine("byteVal = {0}", byteVal);
        }
    }
}
