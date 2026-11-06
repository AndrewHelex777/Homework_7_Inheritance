namespace Homework_7_Inheritance
{
    class Device
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public Device(string n, string m)
        {
            Name = n;
            Model = m;
        }
        public virtual void Sound()
        {
            Console.WriteLine($"Device {Name} produces sound.");
        }
        public virtual void Show()
        {
            Console.WriteLine($"Device name: {Name}.");
        }
        public virtual void Desc()
        {
            Console.WriteLine($"Device: {Name}\nModel: {Model}");
        }
    }
    class Kettle : Device
    {
        public int Volume { get; set; }
        public int Power { get; set; }
        public Kettle(string n, string m, int v, int p) : base(n, m)
        {
            Volume = v;
            Power = p;
        }
        public override void Sound()
        {
            Console.WriteLine($"Kettle {Name} ({Model}) is whistling: Piiiiiiiiiii!");
        }
        public override void Show()
        {
            Console.WriteLine($"Kettle name: {Name}");
        }
        public override void Desc()
        {
            Console.WriteLine($"Kettle description:\nModel: {Model}\nVolume: {Volume} ml\nPower: {Power} W");
        }
    }
    class Microwave : Device
    {
        public int Capacity { get; set; }
        public bool HasGrill { get; set; }
        public Microwave(string n, string m, int c, bool hg) : base(n, m)
        {
            Capacity = c;
            HasGrill = hg;
        }
        public override void Sound()
        {
            Console.WriteLine($"Microwave {Name} is beeping: Beep! Beep!");
        }
        public override void Show()
        {
            Console.WriteLine($"Microwave name: {Name}");
        }
        public override void Desc()
        {
            Console.WriteLine($"Microwave description:\nModel: {Model}\nCapacity: {Capacity} l\nHas grill: {HasGrill}");
        }
    }
    class Car : Device
    {
        public int Horsepower { get; set; }
        public string FuelType { get; set; }
        public Car(string n, string m, int h, string ft) : base(n, m)
        {
            Horsepower = h;
            FuelType = ft;
        }
        public override void Sound()
        {
            Console.WriteLine($"Car {Name} is making noise: Vroooom!");
        }
        public override void Show()
        {
            Console.WriteLine($"Car name: {Name}");
        }
        public override void Desc()
        {
            Console.WriteLine($"Car description:\nModel: {Model}\nHorsepower: {Horsepower} hp\nFuel type: {FuelType}");
        }
    }
    class Steamboat : Device
    {
        public double Displacement { get; set; }
        public int DecksCount { get; set; }
        public Steamboat(string n, string m, double dp, int dc) : base(n, m)
        {
            Displacement = dp;
            DecksCount = dc;
        }
        public override void Sound()
        {
            Console.WriteLine($"Steamboat {Name} is sounding its horn: Tuuu! Tuuu!");
        }
        public override void Show()
        {
            Console.WriteLine($"Steamboat name: {Name}");
        }
        public override void Desc()
        {
            Console.WriteLine($"Steamboat description:\nModel: {Model}\nDisplacement: {Displacement} ton\nDecks count: {DecksCount}");
        }
    }
    internal class Task1
    {
        static void Main(string[] args)
        {
            Device[] devices = new Device[]
            {
                new Kettle("Kettle1", "Bosch TWK", 1700, 2400),
                new Microwave("Microwave1", "Samsung MG23", 23, true),
                new Car("Car1", "Tesla Model 3", 283, "Electric"),
                new Steamboat("Steamboat1", "Model Shipways Chaperon", 1250.5, 3)
            };
            foreach (var item in devices)
            {
                item.Show();
                item.Sound();
                item.Desc();
                Console.WriteLine();
            }
        }
    }
}
