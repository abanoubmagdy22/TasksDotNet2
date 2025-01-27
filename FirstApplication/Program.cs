namespace FirstApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int sum = 0;
            //for (int i = 0; i <= 10; i++)
            //{
            //     sum += i;
            //    sum = sum + i;
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("Please enter first number:");
            //int number1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter second number:");
            //int number2 = Convert.ToInt32(Console.ReadLine());
            //int sum = number1 + number2;
            //Console.WriteLine("==========================");
            //Console.WriteLine("The summition of two numbers is:" +sum);

            double sum = 0;
            Console.WriteLine("please enter first number:");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Please enter second number:");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Please enter operation you want :");
            char op = Convert.ToChar(Console.ReadLine());
            if (op == '+')
            {
                sum = number1 + number2;
                Console.WriteLine("the summition of two numbers is:"+sum);
            }
            else if (op == '-')
            {
                sum = number1 - number2;
                Console.WriteLine("the subtraction of two numbers is:" + sum);

            }
            else if (op == '*')
            {
                sum = number1 * number2;
                Console.WriteLine("the multiplication of two numbers is:" + sum);

            }
            else if (op == '/')
            {
                if(number2 == 0)
                {
                    Console.WriteLine("sorry your number is unlegal");
                }
                else
                {
                    sum = number1 / number2;
                    Console.WriteLine("the divison of two numbers is:" + sum);

                }

            }
            else if (op == '%')
            {
                sum = number1 % number2;
                Console.WriteLine("the modules of two numbers is:" + sum);

            }
            else 
            { 
              Console.WriteLine("Sorry invalid operation");
            }



            
        }
    }
}
