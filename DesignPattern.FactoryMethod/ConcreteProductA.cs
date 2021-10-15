using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod
{
    public class ConcreteProductA : IProduct
    {
        public string GetName()
        {
            return "ConcreteProductA";
        }
    }
    public class ConcreteProductB : IProduct
    {
        public string GetName()
        {
            return "ConcreteProductB";
        }
    }
}
