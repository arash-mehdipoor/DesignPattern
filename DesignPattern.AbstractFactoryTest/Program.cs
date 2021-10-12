using System;

namespace DesignPattern.AbstractFactoryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IMobilePhone nokiaMobilePhone = new Nokia();
            MobileClient nokiaClient = new MobileClient(nokiaMobilePhone);

            Console.WriteLine(nokiaClient.GetNormalPhoneModelDetails());
            Console.WriteLine(nokiaClient.GetSmartPhoneModelDetails());


            Console.ReadKey();
        }
    }
}
