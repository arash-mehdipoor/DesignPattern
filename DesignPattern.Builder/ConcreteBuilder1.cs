using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder
{
    public class ConcreteBuilder1 : IBuilder
    {
        public Product _product;
        public ConcreteBuilder1()
        {
            _product = new Product("Android Cell Phone");
        }

        public Product Product => _product;

        public void BuildOS()
        {
            _product.OS = "Android 4.4";
        }

        public void BuildScreen()
        {
            _product.Screen = "Touch Screen 16 Inch!";
        }
    }
}
