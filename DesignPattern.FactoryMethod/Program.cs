﻿using System;

namespace DesignPattern.FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteCreator factory = new ConcreteCreator();

            IProduct product = factory.FactoryMethod("A");


            Console.WriteLine(product.GetName());
            Console.WriteLine("Hello World!");

            // Another Example
            //    internal class Program
            //{
            //    private static void Main(string[] args)
            //    {
            //        VehicleFactory factory = new ConcreteVehicleFactory();

            //        IFactory scooter = factory.GetVehicle("Scooter");
            //        scooter.Drive(10);

            //        IFactory bike = factory.GetVehicle("Bike");
            //        bike.Drive(20);

            //        Console.ReadKey();

            //    }
            //}

            //public interface IFactory
            //{
            //    void Drive(int miles);
            //}

            //public class Scooter : IFactory
            //{
            //    public void Drive(int miles)
            //    {
            //        Console.WriteLine("Drive the Scooter : " + miles.ToString() + "km");
            //    }
            //}

            //public class Bike : IFactory
            //{
            //    public void Drive(int miles)
            //    {
            //        Console.WriteLine("Drive the Bike : " + miles.ToString() + "km");
            //    }
            //}

            //public abstract class VehicleFactory
            //{
            //    public abstract IFactory GetVehicle(string Vehicle);

            //}

            //public class ConcreteVehicleFactory : VehicleFactory
            //{
            //    public override IFactory GetVehicle(string Vehicle)
            //    {
            //        switch (Vehicle)
            //        {
            //            case "Scooter":
            //                return new Scooter();
            //            case "Bike":
            //                return new Bike();
            //            default:
            //                throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", Vehicle));
            //        }
            //    }
            //}
        }
    }
}
