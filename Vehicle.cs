namespace VehicleSpace
{
    public class Vehicle
    {
        public virtual void Start()
        {
            Console.WriteLine("IN Vehicle");
        }
    }
    public class Car:Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("IN Car");
        }
    }
    public class Bike : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("IN Bike");
        }
    }
}
