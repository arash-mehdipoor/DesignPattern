namespace DesignPattern.Builder
{
    public class ConcreteBuilder2 : IBuilder
    {
        public Product _product;
        public ConcreteBuilder2()
        {
            _product = new Product("Android Cell Phone 2");
        }

        public Product Product => _product;

        public void BuildOS()
        {
            _product.OS = "Android 2";
        }

        public void BuildScreen()
        {
            _product.Screen = "Touch Screen 16 Inch! 2";
        }
    }
}
