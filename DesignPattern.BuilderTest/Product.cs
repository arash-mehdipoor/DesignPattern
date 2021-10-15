using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BuilderTest
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Brand { get; set; }

        public Product(int id, string name, double price, string brand)
        {
            Id = id;
            Name = name;
            Price = price;
            Brand = brand;
        }
    }
    public abstract class BuilderPattern<T>
    {
        public abstract T Build();
    }

    public class ProductBuilder : BuilderPattern<Product>
    {
        public int Id = 1;
        public string Name = "Product 1";
        public double Price = 23000;
        public string Brand = "Brand 1";

        public override Product Build()
        {
            var t = this;
            return new Product(Id, Name, Price, Brand);
        }

        public ProductBuilder WithName(string name)
        {
            this.Name = name;
            return this;
        }

        public ProductBuilder WithPrice(double price)
        {
            this.Price = price;
            return this;
        }

        public ProductBuilder WithBrand(string brand)
        {
            this.Brand = brand;
            return this;
        }
    }
}
