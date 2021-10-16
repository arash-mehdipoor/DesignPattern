using System;

namespace DesignPattern.AbstractFactoryTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            PurchaseFactory spf = new StandardPurchaseFactory();
            Client standard = new Client(spf);

            Console.WriteLine(standard.ClientPackaging.GetType());
            Console.WriteLine(standard.ClientDocument.GetType());



            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
