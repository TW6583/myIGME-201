using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE12_Wu
{
    internal class Program
    {
        public class MyClass
        {
            private string MyString;
            public string myString
            {
                set { myString = MyString; }
            }
            public string returnedString
            {
                get { return MyString; }
            }
            public virtual string GetString()
            {
                return MyString;
            }
        }

        public class MyDerivedClass : MyClass
        {
            public override string GetString()
            {
                return base.GetString() + "(output from the derived class)";    
            }

            
        }

        static void Main(string[] args)
        {
            MyDerivedClass myDerivedClass = new MyDerivedClass();
            Console.WriteLine(myDerivedClass.returnedString);
        }
    }
}
