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


            ConcreteBuilder2 concreteBuilder2 = new ConcreteBuilder2();

            d.Construct(concreteBuilder2);
            Console.WriteLine("Hello World!");
        }
    }
}
