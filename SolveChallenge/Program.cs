namespace SolveChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("enter your favorite number:");
            //int favoritNumber = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"No Reaaly!! {favoritNumber} is your favorite number!");


            int x = 75;
            int y = 50;
            if (x > y)
            {

                Console.WriteLine("x is greater than y");
            }

            int t = 20;
            if (t < 18)
            {
                Console.WriteLine("good day");
            }
            else
            {
                Console.WriteLine("good evening");

            }
            int time = 20;
            string result = (time < 18) ? "good morning" : "good evening";
            Console.WriteLine(result);


            int day = 4 ;
            switch (day)
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
            }


            //string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            //foreach (string i in cars)
            //{
            //    Console.WriteLine(i);

            //string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            //for (int i = 0; i < cars.Length; i++)
            //{
            //    Console.WriteLine(cars[i]);
            //}

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda","Col" };
            Array.Sort(cars);
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }

            int[] myNumbers = { 6, 8, 4, 2, 10, 17 };
            Array.Sort(myNumbers);
            //for (int i = 0; i < myNumbers.Length; i++)
            //{
                //Console.WriteLine(myNumbers[i]);
                //Console.WriteLine(myNumbers.Max());
                //Console.WriteLine(myNumbers.Min());
                //Console.WriteLine(myNumbers.Sum());
            //}


            int[] arr = new int[5];
            arr[0] = 100; 
            //first way
            arr[4] = 1000;
            //second way 
            arr[^1] = 1000;

            Console.WriteLine("First element: " + arr[0]);
            Console.WriteLine("Last element: " + arr[4]);
            Console.WriteLine("Last element with second way: " + arr[^1]);
            Console.WriteLine("Element at index 2: " + arr[2]);



            List<int> myList = new List<int>();
            Console.Write("Please enter a value: ");
            int xInput = Convert.ToInt32(Console.ReadLine());
            myList.Add(xInput);
            Console.WriteLine(myList[0]);
            Console.WriteLine("The size: " + myList.Count);





        }


    }
}
