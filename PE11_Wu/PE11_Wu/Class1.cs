using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE11_Wu
{
    //Timothy Wu
    //PE11
    //Q5
    //Create Vehicle class
    public abstract class Vehicle
    {
        public virtual void LoadPassenger()
        {

        }
    }

    public interface IPassengerCarrier
    {
        void LoadPassenger();
    }
    public interface IHeavyLoadCarrier
    {

    }

    public abstract class Car : Vehicle
    {

    }


    public abstract class Train : Vehicle
    {

    }

    public class Compact : Car 
    {
        

    }

    

    public class SUV : Car
    {

    }

    public class Pickup : Car
    {

    }

    public class PassengerTrain : Train
    {

    }

    public class FreightTrain : Train
    {

    }

    public class _424DoubleBogey : Train
    {

    }






}
