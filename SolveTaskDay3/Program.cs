using System.Collections.Generic;
using System.Diagnostics.Metrics;

namespace SolveTaskDay3
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<int> numbers = new List<int>();
            char choice = '\0';

            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n Menu Select your option:");
                Console.WriteLine("=============================");
                Console.ForegroundColor = ConsoleColor.Green;
                // options of list 
                Console.WriteLine("P - Print numbers");
                Console.WriteLine("A - Add a number");
                Console.WriteLine("M - Display mean of the numbers");
                Console.WriteLine("S - Display the smallest number");
                Console.WriteLine("L - Display the largest number");
                Console.WriteLine("Q - Quit");
                //select your choice from option
                Console.Write("Enter your choice: ");
                //accept uppercase or lowercase
                string myInput = Console.ReadLine().Trim().ToUpper();

                if (myInput.Length == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Unknown selection, please try again!");
                    continue;
                }
                //first character 
                choice = myInput[0];

                //loop for choices options
                switch (choice)
                {
                    case 'P':
                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("[] - the list is empty");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("[");

                            for (int i = 0; i < numbers.Count; i++)
                            {
                                Console.Write(numbers[i]);
                                if (i < numbers.Count - 1)
                                {
                                    Console.Write(" ");
                                }
                            }

                            Console.WriteLine("]");
                            Console.ForegroundColor = ConsoleColor.White;

                        }
                        break;

                    case 'A':
                        Console.Write("Enter an integer to add to the list: ");
                        string input = Console.ReadLine();
                        int number;
                        if (int.TryParse(input, out number))
                        {
                            numbers.Add(number);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine($"{number} added");

                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid input, Please enter an integer.");
                        }
                        break;
                    case 'M':
                        if (numbers.Count == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Unable to calculate mean or average--no data");
                        }
                        else
                        {
                            int sum = 0;
                            foreach (int num in numbers)
                            {
                                sum += num;
                            }

                            double mean = (double)sum / numbers.Count;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine($"The mean/average of the numbers is {mean}");
                        }
                        break;

                    case 'S':
                        if (numbers.Count == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Unable to determine smallest number in the list - list is empty");
                        }
                        else
                        {
                            int smallest = numbers[0];
                            //foreach (int num in numbers)
                            for (int i = 1;i<=numbers.Count;i++)
                            {
                                if (numbers[i] < smallest)
                                {
                                    smallest = numbers[i];
                                }
                            }
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine($"The smallest number in the list is {smallest}");
                        }
                        break;

                    case 'L':
                        if (numbers.Count == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Unable to determine largest number in the list - list is empty");
                        }
                        else
                        {
                            int largest = numbers[0];
                            foreach (int num in numbers)
                            {
                                if (num > largest)
                                {
                                    largest = num;
                                }
                            }
                            //for (int i = 1; i <= numbers.Count; i++)
                            //{
                            //    if (numbers[i] > largest)
                            //    {
                            //        largest = numbers[i];
                            //    }
                            //}
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine($"The largest number in the list is {largest}");
                        }
                        break;

                    case 'Q':
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Unknown Selection, Please try again!");
                        break;
                }
            } while (choice != 'Q');
        }
    }
}
        //Console.ForegroundColor = ConsoleColor.Yellow;
        //Console.WriteLine("\n Menu Select your option:");
        //Console.WriteLine("=============================");
        //Console.ForegroundColor = ConsoleColor.Green;
        //// options of list 
        //Console.WriteLine("P - Print numbers");
        //Console.WriteLine("A - Add a number");
        //Console.WriteLine("M - Display mean of the numbers");
        //Console.WriteLine("S - Display the smallest number");
        //Console.WriteLine("L - Display the largest number");
        //Console.WriteLine("Q - Quit");
//        Console.WriteLine("Q - Quit");
//        Console.Write("Enter your choice: ");
//        //accept uppercase
//        string input = Console.ReadLine().Trim().ToUpper();

//        if (input.Length == 0)
//        {
//            Console.WriteLine("Unknown selection, please try again!");
//            continue;
//        }

//        //choice = input[0];

//        if (choice == 'P')
//        {
//            if (numbers.Count == 0)
//            {
//                Console.WriteLine("[] - the list is empty");
//            }
//            else
//            {
//                Console.Write("[");
//                for (int i = 0; i < numbers.Count; i++)
//                {
//                    Console.Write(numbers[i]);
//                    if (i < numbers.Count - 1)
//                    {
//                        Console.Write(" ");
//                    }
//                }
//                Console.WriteLine("]");
//            }
//        }
//        else if (choice == 'A')
//        {
//            Console.Write("Enter an integer to add to the list: ");
//            if (int.TryParse(Console.ReadLine(), out int number))
//            {
//                numbers.Add(number);
//                Console.WriteLine($"{number} added");
//            }
//            else
//            {
//                Console.WriteLine("Invalid input, Please enter an integer.");
//            }
//        }
//        else if (choice == 'M')
//        {
//            if (numbers.Count == 0)
//            {
//                Console.WriteLine("Unable to calculate mean or average--no data");
//            }
//            else
//            {
//                int sum = 0;
//                foreach (int num in numbers)
//                {
//                    sum += num;
//                }
//                double mean = (double)sum / numbers.Count;
//                Console.WriteLine($"The mean/averag of the numbers is {mean}");
//            }
//        }
//        else if (choice == 'S')
//        {
//            if (numbers.Count == 0)
//            {
//                Console.WriteLine("Unable to determine smallest number in the list - list is empty");
//            }
//            else
//            {
//                int smallest = numbers[0];
//                foreach (int num in numbers)
//                {
//                    if (num < smallest)
//                    {
//                        smallest = num;
//                    }
//                }
//                Console.WriteLine($"The smallest number in the list is {smallest}");
//            }
//        }
//        else if (choice == 'L')
//        {
//            if (numbers.Count == 0)
//            {
//                Console.WriteLine("Unable to determine largest number in the list - list is empty");
//            }
//            else
//            {
//                int largest = numbers[0];
//                foreach (int num in numbers)
//                {
//                    if (num > largest)
//                    {
//                        largest = num;
//                    }
//                }
//                Console.WriteLine($"The largest number in the list is {largest}");
//            }
//        }
//        else if (choice == 'Q')
//        {
//            Console.WriteLine("Goodbye!");
//        }
//        else
//        {
//            Console.WriteLine("Unknown Selection, Please try again!");
//        }
//    } while (choice != 'Q');
//}




