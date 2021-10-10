using System;

namespace DesignPattern.Singleton
{
    public class Program
    {
        static void Main(string[] args)
        {
            SingletonDesignPattern();

            Console.ReadKey();
        }


        //Singleton
        private static void SingletonDesignPattern()
        {
            var firstSingleTon = SingletonClassCreator<FirstSingleton>.SingletoneInstance;
            var towSingleTon = SingletonClassCreator<FirstSingleton>.SingletoneInstance;
            Console.WriteLine(firstSingleTon.Square(12));
            Console.WriteLine(towSingleTon == firstSingleTon);
        }
    }
}
