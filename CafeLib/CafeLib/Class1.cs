using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeLib
{
    public abstract class HotDrink
    {
        public bool instant;
        public bool milk;
        public byte sugar;
        public string size;
        public Customer customer;

        public virtual void AddSugar(byte amount)
        {

        }


        public abstract bool Steam();

        public HotDrink()
        {
        }

        public HotDrink(string brand)
        {
        }

    }

    public interface IMood
    {
        string Mood
        {
            get;
        }

    }

    public class Waiter : IMood
    {
        public string name;
        public string Mood
        {
            get;
        }

        public void ServerCustomer(HotDrink cup)
        {

        }
    }

    public class Customer : IMood
    {
        public string name;
        public string creditCardNumber;

        public string Mood
        {
            get;
        }

    }

    public interface ITakeOrder
    {
        void TakeOrder();
    }

    public class CupOfCoffee : HotDrink, ITakeOrder
    {
        public string beanType;

        public override bool Steam()
        {
            return true;
        }

        public void TakeOrder()
        {

        }

        public CupOfCoffee(string brand) : base(brand)
        {

        }

    }

    public class CupOfTea : HotDrink, ITakeOrder
    {
        public string leafType;

        public override bool Steam()
        {
            return false;
        }

        public void TakeOrder()
        {

        }

        public CupOfTea(bool customerIsWealthy)
        {

        }

    }

    public class CupOfCoccoa : HotDrink, ITakeOrder
    {
        public static int numCups;
        public bool marshmallows;
        private string source;

        public string Source
        {
            get;
        }

        public override bool Steam()
        {
            return true;
        }

        public override void AddSugar(byte amount)
        {

        }

        public void TakeOrder()
        {

        }

        public CupOfCoccoa() : this(false)
        {

        }

        public CupOfCoccoa(bool marshmallows) : base("Expensive Organic Brand")
        {

        }
    }
}
