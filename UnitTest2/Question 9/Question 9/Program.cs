using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_9
{
    public interface SkateboardInterface
    {
        bool Stationery();

        bool Balancing();

        bool Pushing();

    }

    public abstract class Skateboard
    {
        public string wheelType;
        public int wheelSize;
        public string trucksBrand;
        public bool isStationery;

        public virtual bool Stationery()
        {
            if (isStationery == true)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public abstract bool Balancing();
        public abstract bool Pushing();
    }


    public class Cruising : Skateboard, SkateboardInterface
    {
        public bool balancingOnly;
        public override bool Balancing()
        {
            if (balancingOnly == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override bool Pushing()
        {
            return balancingOnly = false;
        }

        public int Speed()
        {
            int speed = 0;
            return speed;
        }

    }

    public class Ollie : Skateboard, SkateboardInterface
    {
        public override bool Balancing()
        {
            return true;
        }

        public override bool Pushing()
        {
            return false;
        }

        public bool boardPopped()
        {
            return true;
        }
        
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Cruising cruising = new Cruising();
            Ollie ollie = new Ollie();

            cruising.balancingOnly = true;

        }
    }
}
