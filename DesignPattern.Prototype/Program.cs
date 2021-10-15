using System;

namespace DesignPattern.Prototype
{
    class Program
    {
        static void Main(string[] args)
        {

            Developer developer = new Developer();
            developer.Name = "Arash";
            developer.Age = 28;
            developer.Language = "C#";

            Developer developerCopy = (Developer) developer.Clone();
            developerCopy.Name = "Ali";

            Console.WriteLine("Hello World!");
        }
    }
}
