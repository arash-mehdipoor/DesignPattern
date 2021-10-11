using System;

namespace DesignPattern.Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {

            IVehicleFactory factory = new IranKhodro();
            Console.WriteLine("***" + factory.GetType().Name + "***");


            IDiesel diesel = factory.GetDiesel();
            Console.WriteLine(diesel.GetName());


            IMotorCar motorCar = factory.GetMotorCar();
            Console.WriteLine(motorCar.GetName());

            Console.ReadKey();
        }
    }
}
