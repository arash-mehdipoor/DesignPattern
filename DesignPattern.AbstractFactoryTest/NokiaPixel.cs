using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryTest
{
    public class NokiaPixel : ISmartPhone
    {
        public string GetModelDetail()
        {
            return "Model: Nokia Pixel";
        }
    }
}
