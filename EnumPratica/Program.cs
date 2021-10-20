using System;

namespace EnumPratica
{
    class Program
    {
        static void Main(string[] args)
        {
            Product mouse = new Product(1, "Mouse Gmaer", 299.97, EProductType.Product);
            mouse.Id = 55;
            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);
            Console.WriteLine(mouse.Type);
            Console.WriteLine((int)mouse.Type);
        }

        struct Product
        {
            public Product(int id, string name, double price, EProductType type){
                Id =id;
                Name = name;
                Price = price;
                Type = type;
            }

            public int Id;
            public string Name;
            public double Price;
            public EProductType Type;

            public double PriceDolar(double dolar){
                return Price * dolar;
            }  
            
        }

        enum EProductType
        {
            Product = 1,
            Serivce = 2
        }
    }
}
