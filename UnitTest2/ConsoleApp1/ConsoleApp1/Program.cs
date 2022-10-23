using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //Questions 4

    public abstract class Phone
    {
        private string phoneNumber;
        public string address;

        public string PhoneNumber;
        public abstract void Connect();
        public abstract void Disconnect();

    }

    public interface PhoneInterface
    {
        void Answer();
        void MakeCall();
        void HangUp();

    }

    public class RotaryPhone : Phone, PhoneInterface
    {
        public void Answer()
        {

        }

        public void MakeCall()
        {

        }

        public void HangUp()
        {

        }

        public override void Connect()
        {

        }

        public override void Disconnect()
        {

        }
    }

    public class PushBottonPhone : Phone, PhoneInterface
    {
        public void Answer()
        {

        }
        public void MakeCall()
        {

        }

        public void HangUp()
        {

        }

        public override void Connect()
        {

        }

        public override void Disconnect()
        {

        }

    }

    public class Tardis : RotaryPhone
    {
        private bool sonicScrewdriver;
        private byte whichDrWho;
        private string femaleSideKick;
        public double exteriorSurfaceArea;
        public double interiorVolume;

        public byte WhichDrWho
        {
            get
            {
                return this.whichDrWho;
            }
        }

        public string FemaleSideKick
        {
            get
            {
                return this.femaleSideKick;
            }
        }

        public void TimeTravel()
        {

        }

        //Quesstion 5

        public static bool operator >(Tardis DrTen, Tardis DrNine)
        {
            return (DrTen.whichDrWho > DrNine.whichDrWho);
        }
        public static bool operator >=(Tardis DrNine, Tardis DrEight)
        {
            return (DrNine.whichDrWho >= DrEight.whichDrWho) || (DrNine.whichDrWho == DrEight.whichDrWho);
        }
        public static bool operator <=(Tardis DrEight, Tardis DrSeven)
        {
            return (DrSeven.whichDrWho <= DrEight.whichDrWho);
        }
        public static bool operator <(Tardis DrSeven, Tardis DrSix)
        {
            return (DrSix.whichDrWho < DrSeven.whichDrWho);
        }
    }

    public class PhoneBooth : PushBottonPhone
    {
        private bool superMan;
        public double costPerCall;
        public bool phoneBook;

        public void OpenDoor()
        {

        }

        public void CloseDoor()
        {

        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
