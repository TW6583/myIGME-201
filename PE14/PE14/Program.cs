using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE14

    //Name: Timothy Wu
    //PE14

{
    //PE14 Q1
    //public abstract class that reads and writes a private string
    public abstract class readWriteClass
    {
        private string privString;

        public string stringAccessor
        {
            get
            {
                return privString;
            }
            set
            {
                privString = value;
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
