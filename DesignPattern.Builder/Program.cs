using System;

namespace DesignPattern.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Director d = new Director();
            ConcreteBuilder1 cb1 = new ConcreteBuilder1();
            d.Construct(cb1);

            Console.WriteLine("Hello World!");
        }
    }
}
