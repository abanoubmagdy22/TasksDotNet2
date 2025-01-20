namespace LoopSummition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int i = 1; i <= 15; i++)
            {
                if (i % 2 != 0) // Check if the number is odd
                {
                    sum += i; // Add the odd number to the sum
                }
            }

            Console.WriteLine("The sum of odd numbers from 1 to 15 is: " + sum);
        }
    }
}
