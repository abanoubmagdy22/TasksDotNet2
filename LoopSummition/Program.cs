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

            int sum2 = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    sum2 += i;
                }
            }
            Console.WriteLine("The summition of even numbers from 1 to 100 is :" + sum2);

            Console.WriteLine("the natural numbers from 1 to 10 are:");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            int sum3 = 0;
            for (int i = 0; i <= 10; i++)
            {
                sum += i;
            }
            Console.WriteLine("the summition of numbers from 1 to 10 is :" + sum3);

            int num1, num2;
            Console.WriteLine("Please enter number1:");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter number2:");
            int number2 = int.Parse(Console.ReadLine());
            int sum4 = 0;
            if (number1 == number2)
            {
                sum4 = number1 + number2;
            }
            else
            {
                sum4 = number1 * number2;
            }
            Console.WriteLine("the summition of two numbers is:" + sum4);

            //int num1, num2, sum = 0;
            //Console.WriteLine("Enter number1:");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter number2:");
            //int number2 = int.Parse(Console.ReadLine());
            //if (number1 == number2)
            //{
            //    sum = (number1 + number2) * 3;
            //}
            //else
            //{
            //    sum = number1 + number2;
            //}
            //Console.WriteLine("the summition of two numbers is:" + sum);

            int num11 ,num22,sum22 = 0 ;
            Console.WriteLine("please enter number1:");
            int number11 = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter number2:");
            int number22 = int.Parse(Console.ReadLine()); 
            int summition = number1 + number2;
            Console.WriteLine("the summition of two numbers is:" + summition);
            if (number11 == 30 || number22 == 30 || summition == 30)
            {
                Console.WriteLine("True");
            }
            else {
                Console.WriteLine("False");
            }


        }
    }
}
