using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PE13_Wu
{
    public abstract class Pet
    {

    }


    public class Pets
    {
        public List<Pet> petList = new List<Pet>();

        public Pet this[int nPetEl]
        {
            get
            {
                Pet returnVal;
                try
                {
                    returnVal = (Pet)petList[nPetEl];
                }
                catch
                {
                    returnVal = null;
                    
                }
                return (returnVal);
            }

            set
            {
                //if the index is less than the number of list elements
                if (nPetEl < petList.Count)
                {
                    //update the existing value at that index
                    petList[nPetEl] = value;
                }
                else
                {
                    //add the value to the list
                    petList.Add(value);
                }

            }

        }
        /*public readonly int Count
        {
            return petList.Count;
        }*/
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
        }
    }
}
