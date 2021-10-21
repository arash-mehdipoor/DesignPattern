using System;

namespace DesignPattern.Adapter
{

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public Product(int id, string name, int price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }

    public abstract class Builder<T>
    {
        public abstract T Build();
    }


    public class ProductBuider : Builder<Product>
    {

        public int Id = 1;
        public string Name = "";
        public int Price = 2;


        public string GetName(string name)
        {

            return this.Name = name;
        }

        public int GetPrice(int price)
        {

            return this.Price = price;
        }

        public override Product Build()
        {
            return new Product(Id, Name, Price);
        }
    }




    class Program
    {
        static void Main(string[] args)
        {

            var productbuider = new ProductBuider();
            var product1 = productbuider.GetPrice(120);


            Adapter adapter = new Adapter();
            client client = new client(adapter);

            client.MakeRequest();

            Console.ReadKey();
        }
    }
}
