namespace Homework_7_Inheritance
{
    class Course
    {
        public string Name { get; set; }
        public int Duration { get; set; }
        public Course(string n, int d)
        {
            Name = n;
            Duration = d;
        }
        public override string ToString()
        {
            return $"Name of course: {Name}, duration: {Duration} hours.";
        }
    }
    class OnlineCourse : Course
    {
        public string Platform { get; set; }
        public OnlineCourse(string n, int d, string p) : base(n, d)
        {
            Platform = p;
        }
        public override string ToString()
        {
            return $"{base.ToString()} Platform: {Platform}.";
        }
    }
    internal class Task2
    {
        static void Main(string[] args)
        {
            Course c = new Course(".NET and C#", 40);
            OnlineCourse oc = new OnlineCourse("OOP", 60, "Microsoft Teams");
            Console.WriteLine(c);
            Console.WriteLine(oc);
        }
    }
}
