using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
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
            string sumNums;
            Console.WriteLine(this.nOne + this.nTwo + " is the sum");
            sumNums = Console.ReadLine();
            return sumNums;
        }
    }

    //class that inherits anInterface and combines two strings
    public class combineStrings : anInterface
    {
        public string strOne;
        public string strTwo;

        public string strInterface()
        {
            string combinedString;
            Console.WriteLine(this.strOne + " " + this.strTwo);
            combinedString = Console.ReadLine();
            return combinedString;
        }
    }



    internal class Program
    {
        //PE14 Q3
        //calls an anInterface object's strInterface()
        public static void MyMethod(anInterface myObject)
        {
            myObject.strInterface();
        }
        static void Main(string[] args)
        {
            //Creates an object from each class
            addingNums addingNums = new addingNums();
            combineStrings combineStrings = new combineStrings();
            //sets the numbers
            addingNums.nOne = 3;
            addingNums.nTwo = 6;
            //sets the strings
            combineStrings.strOne = "Hello there.";
            combineStrings.strTwo = "Hello to you too.";
            //calls the .strInterface() method in each class
            MyMethod(addingNums);
            MyMethod(combineStrings); 

        }
    }
}
