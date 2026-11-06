namespace Homework_7_Inheritance
{
    abstract class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Product(string n, double p)
        {
            Name = n;
            Price = p;
        }
        public abstract double CalculateDiscount();
    }
    class Electronics : Product
    {
        public Electronics(string n, double p) : base(n, p)
        {
        }
        public override double CalculateDiscount()
        {
            return Price * 0.10;
        }
    }
    class Furniture : Product
    {
        public Furniture(string n, double p) : base(n, p)
        {
        }
        public override double CalculateDiscount()
        {
            return Price * 0.15;
        }
    }
    internal class Task3
    {
        static void Main(string[] args)
        {
            Product[] p = new Product[]
            {
                new Electronics("Laptop", 30000),
                new Electronics("Phone", 15000),
                new Furniture("Table", 8000),
                new Furniture("Chair", 3000)
            };
            foreach (var item in p)
            {
                double d = item.CalculateDiscount();
                Console.WriteLine($"Product: {item.Name}");
                Console.WriteLine($"Price: {item.Price}");
                Console.WriteLine($"Discount: {d}");
                Console.WriteLine($"Price with discount: {item.Price - d}");
            }
        }
    }
}
