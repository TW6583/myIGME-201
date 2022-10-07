using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


//Name: Timothy Wu
//HW: PE13



namespace PE13
{
    public abstract class Pet
    {
        private string name;
        public int age;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }

        }

        public abstract string Eat();
        public abstract string Play();
        public abstract string GoToVet();

        public Pet()
        {

        }

        public Pet(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
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
        public int Count
        {
            get
            {
                return petList.Count;
            }
        }

        public void Add(Pet pet)
        {
            petList.Add(pet); 
        }

        public void Remove(Pet pet)
        {
            petList.Remove(pet);
        }

        public void RemmoveAt(int petEl)
        {
            petList.RemoveAt(petEl);
        }
    }

    public interface ICat
    {
        string Eat();
        string Play();
        string Scratch();
        string Purr();
    }

    public class Cat : Pet, ICat
    {
        public override string Eat()
        {
            return this.Name + ": Where is my food human?";
        }
        public override string Play()
        {

            return this.Name + ": Meow, what is that red dot?";
        }
        public override string GoToVet()
        {
            return this.Name + ": Hiss! Don't take me to the vile vet!";
        }

        public string Purr()
        {
            return this.Name + ": Purrrrrr purrrrrr.";
        }

        public string Scratch()
        {
            return this.Name + ": Scratch scratch, my claws are deadly weaponns now!";
        }

        public Cat()
        {
            Console.WriteLine("A Cat has been bought!");
        }
    }

    public interface IDog
    {
        string Eat();
        string Play();
        string GoToVet();
        string Bark();
        string NeedWalk();
    }

    public class Dog : Pet, IDog
    {
        public string license;

        public override string Eat()
        {
            return this.Name + ": Munch Mumch, this food is great!";
        }
        public override string Play()
        {
            return this.Name + ": Pant pant, throw the ball!";
        }
        public override string GoToVet()
        {
            return this.Name + ": Grrrr, don't take me to the vet!";
        }
        public string Bark()
        {
            return this.Name + ": Woof! Woof!";
        }
        public string NeedWalk()
        {
            return this.Name + ": Woof! Take me on a walk!";
        }
        
        public Dog(string szLicense, string szName, int nAge) : base(szName, nAge)
        {
            this.license = szLicense;
            this.Name = szName;
            this.age = nAge;
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Pet thisPet = null;
            Dog dog = null;
            Cat cat = null;
            IDog iDog = null;
            ICat iCat = null;
            
            Pets pets = new Pets();

            Random rand = new Random();
            
            for (int i = 0; i < 50; i++)
            {
                if ( rand.Next(1, 11) == 1)
                {
                    if ( rand.Next(0, 2) == 0)
                    {
                        pets.Add(dog);
                    }
                    else
                    {
                        pets.Add(cat);
                    }

                }
                else
                {
                    
                    if (thisPet == null)
                    {
                        continue;
                    }
                    if (thisPet is Cat)
                    {
                        switch(rand.Next(0, 4))
                        {
                            case 0: iCat.Eat();
                                break;
                            case 1: iCat.Play();
                                break;
                            case 2: iCat.Scratch();
                                break;
                            case 3: iCat.Purr();
                                break;
                        }

                    }
                    else
                    {
                        switch(rand.Next(0, 4))
                        {
                            case 0: iDog.Eat();
                                break;
                            case 1: iDog.Play();
                                break;
                            case 2: iDog.Bark();
                                break;
                            case 3: iDog.NeedWalk();
                                break;
                            case 4: iDog.GoToVet();
                                break;
                        }

                    }
                }
            }

        }
    }
}
