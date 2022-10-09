using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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


    //PE 14 Q2
    //Interface that will be inherited by two classes
    public interface anInterface
    {
        string strInterface();
    }

    //class that inherits anInterface and will add two ints and will return the sum along with a string stating its number
    public class addingNums : anInterface
    {
        public int nOne;
        public int nTwo;

        public string strInterface()
        {
            return this.nOne + this.nTwo + ": is the sum";
        }
    }

    //class that inherits anInterface and combines two strings
    public class combineStrings : anInterface
    {
        public string strOne;
        public string strTwo;

        public string strInterface()
        {
            return this.strOne + " " + this.strTwo;
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
