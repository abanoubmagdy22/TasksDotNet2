using System;

// Abstract class Employee
abstract class Employee
{
    public string Name { get; set; }
    public Employee(string name)
    {
        Name = name;
    }
    public abstract decimal CalculateSalary();
}

// FullTimeEmployee class
class FullTimeEmployee : Employee
{
    private decimal fixedSalary;

    public FullTimeEmployee(string name, decimal fixedSalary) : base(name)
    {
        this.fixedSalary = fixedSalary;
    }

    public override decimal CalculateSalary()
    {
        return fixedSalary;
    }
}

// PartTimeEmployee class
class PartTimeEmployee : Employee
{
    private int hoursWorked;
    private decimal hourlyRate;

    public PartTimeEmployee(string name, int hoursWorked, decimal hourlyRate) : base(name)
    {
        this.hoursWorked = hoursWorked;
        this.hourlyRate = hourlyRate;
    }

    public override decimal CalculateSalary()
    {
        return hoursWorked * hourlyRate;
    }
}

class Program
{
    static void Main()
    {
        Employee fullTimeEmp = new FullTimeEmployee("Alice", 5000);
        Employee partTimeEmp = new PartTimeEmployee("Bob", 20, 15);

        Console.WriteLine($"{fullTimeEmp.Name}'s Salary: {fullTimeEmp.CalculateSalary()} USD");
        Console.WriteLine($"{partTimeEmp.Name}'s Salary: {partTimeEmp.CalculateSalary()} USD");
    }
}
