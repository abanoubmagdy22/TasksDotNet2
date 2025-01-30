namespace FirstApplication
{
    internal class Program
    {

        class Player
        {
            public string Name { get; set; }
            public int Health { get; set; }
            public double Experience { get; set; }

            public string Shooting(Player otherplayer)
            {
                return $"{Name} is shooting the ball to {otherplayer.Name}";
            }

            public Player(string name = "pop", int health = 0, double exp = 0.0)
            {
                Name = name;
                Health = health;
                Experience = exp;
            }
            //first method oveloding operator +
            public static Player operator +(Player p1, Player p2)
            {
                return new Player(p1.Name + "  " + p2.Name, p1.Health + p2.Health, p1.Experience + p2.Experience);
            }

            //second method Overloading ++ operator
            public static Player operator ++(Player p)
            {
                return new Player(p.Name.ToUpper(), p.Health + 1, p.Experience + 1);
            }
        }

        static void Main(string[] args)
        {
            Player p1 = new("Cr7",10,22.5);
            Player p2 = new Player("messi");
            Console.WriteLine(p1.Shooting(p2));
            Player newPlayer = p1 + p2;
            Console.WriteLine($"Name of player: {newPlayer.Name}, Health: {newPlayer.Health}, Experience: {newPlayer.Experience}");

            p1++;
            Console.WriteLine($"Name of player after ++operator: {p1.Name}, Health: {p1.Health}, Experience: {p1.Experience}");
            #region first code 
            //int sum = 0;
            //for (int i = 0; i <= 10; i++)
            //{
            //     sum += i;
            //    sum = sum + i;
            //    Console.WriteLine(i);
            //}
            #endregion
            #region second code
            //Console.WriteLine("Please enter first number:");
            //int number1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter second number:");
            //int number2 = Convert.ToInt32(Console.ReadLine());
            //int sum = number1 + number2;
            //Console.WriteLine("==========================");
            //Console.WriteLine("The summition of two numbers is:" +sum);
            #endregion
            #region third code calculator
            //double sum = 0;
            //Console.WriteLine("please enter first number:");
            //double number1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(" Please enter second number:");
            //double number2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(" Please enter operation you want :");
            //char op = Convert.ToChar(Console.ReadLine());
            //if (op == '+')
            //{
            //    sum = number1 + number2;
            //    Console.WriteLine("the summition of two numbers is:"+sum);
            //}
            //else if (op == '-')
            //{
            //    sum = number1 - number2;
            //    Console.WriteLine("the subtraction of two numbers is:" + sum);

            //}
            //else if (op == '*')
            //{
            //    sum = number1 * number2;
            //    Console.WriteLine("the multiplication of two numbers is:" + sum);

            //}
            //else if (op == '/')
            //{
            //    if(number2 == 0)
            //    {
            //        Console.WriteLine("sorry your number is unlegal");
            //    }
            //    else
            //    {
            //        sum = number1 / number2;
            //        Console.WriteLine("the divison of two numbers is:" + sum);

            //    }

            //}
            //else if (op == '%')
            //{
            //    sum = number1 % number2;
            //    Console.WriteLine("the modules of two numbers is:" + sum);

            //}
            //else 
            //{ 
            //  Console.WriteLine("Sorry invalid operation");
            //}
            #endregion




        }
    }
}
