using System.Diagnostics.CodeAnalysis;

namespace ChallengeDay4
{
    internal class Program
    {
        static void Calculator(int num1, int num2 ,string op)
        {
            switch (op)
            {
                case "+":
                    Console.WriteLine(num1+num2);
                    break;
                case "-":
                    Console.WriteLine(num1 - num2);
                    break;
                case "*":
                    Console.WriteLine(num1 * num2);
                    break;
                case "/":
                    Console.WriteLine(num1 / num2);
                    break;
            }
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Console.WriteLine("enter first num:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second num:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter oprtation");
            string op = Console.ReadLine();
            Calculator(num1, num2, op);

        }
    }
}
