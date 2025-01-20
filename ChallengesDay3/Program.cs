using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace ChallengesDay3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double temperature = 0;
            //int windSpeed = 0;

            //const int windSpeedForCoat = 25;      
            //const double temperatureForCoat = 22; 

            //Console.Write("Enter temperature: ");
            //temperature = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter speed: ");
            //windSpeed = Convert.ToInt32(Console.ReadLine());
            //bool wearCoat = (temperature < temperatureForCoat) || (windSpeed > windSpeedForCoat);
            //Console.WriteLine(wearCoat);

            //double baseCost = 2.50;
            //double surcharge = 0;

            //Console.Write("Enter the length of shipping: ");
            //int length = int.Parse(Console.ReadLine());

            //Console.Write("Enter the width of shipping: ");
            //int width = int.Parse(Console.ReadLine());

            //Console.Write("Enter the height of shipping: ");
            //int height = int.Parse(Console.ReadLine());

            //int volumeOfShipping = length * width * height;
            //if (volumeOfShipping > 500)
            //{
            //    surcharge += baseCost * 1.25;
            //}
            //else if (volumeOfShipping > 100)
            //{
            //    surcharge += baseCost * 1.1;
            //}
            //Console.WriteLine(surcharge);


            int dayCode = 0;
            Console.Write("Enter dayCode: ");
            dayCode = Convert.ToInt32(Console.ReadLine());
            switch (dayCode)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day code");
                    break;
            }
        }



    }



    }

