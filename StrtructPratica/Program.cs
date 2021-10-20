using System;

namespace StrtructPratica
{
    class Program
    {
        static void Main(string[] args)
        {
            Product mouse = new Product(1, "Mouse Gmaer", 299.97);
            mouse.Id = 55;
            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);
        }

        struct Product
        {
            public Product(int id, string name, double price){
                Id =id;
                Name = name;
                Price = price;
            }

            public int Id;
            public string Name;
            public double Price;

            public double PriceDolar(double dolar){
                return Price * dolar;
            }  
            
        }
    }
}
