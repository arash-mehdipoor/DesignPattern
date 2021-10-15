using System;

namespace DesignPattern.BuilderTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ProductBuilder();

            var product1 = builder.Build();

            var product2 = builder.WithPrice(3000).Build();


            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
