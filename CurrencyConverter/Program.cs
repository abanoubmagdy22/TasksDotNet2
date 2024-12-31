namespace CurrencyConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter your favorite number between 1 and 100!\r\n");
            //int number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Amazing!! That's my favorite number too!\r\n");  
            //Console.WriteLine($"No really!!, {number} is my favorite number!");  

            double rate = 50;

            Console.WriteLine("Enter your name: ");

            string name = Console.ReadLine();

            Console.WriteLine($"Hello {name}...");

            Console.WriteLine("Enter the currency in USD that you want to convert to EGP pounds: ");

            double currencyUSD = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"currency in EGP: {currencyUSD * rate}");

        }
    }
}
