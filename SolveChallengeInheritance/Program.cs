namespace SolveChallengeInheritance
{
    class Person
    {
        protected string Name;
        protected int Age;
        protected string Address;
        protected string Nationality;

        public Person(string name, int age, string address, string nationality)
        {
            Name = name;
            Age = age;
            Address = address;
            Nationality = nationality;
        }
    }

    class Student : Person
    {
        public string StudyLevel { get; set; }
        public string Specialization { get; set; }
        public double GPA { get; set; }

        public Student(string name, int age, string address, string nationality, string studyLevel, string specialization, double gpa)
            : base(name, age, address, nationality)
        {
            StudyLevel = studyLevel;
            Specialization = specialization;
            GPA = gpa;
        }
    }

    class Employee : Person
    {
        public double Salary { get; set; }
        public string Rank { get; set; }
        public string Job { get; set; }

        public Employee(string name, int age, string address, string nationality, double salary, string rank, string job)
            : base(name, age, address, nationality)
        {
            Salary = salary;
            Rank = rank;
            Job = job;
        }
    }

    internal class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
