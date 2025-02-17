namespace SolveChallengeInterface
{
     interface IPayment
    {
        string ProcessPayment(decimal amount);
    }
    public class CreditCardPayment : IPayment
    {
        public string ProcessPayment(decimal amount)
        {
            return " Processes payment with a credit card";
        }
    }
    public class PayPalPayment : IPayment
    {
        public string ProcessPayment(decimal amount)
        {
            return "Processes payment via PayPal.";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            IPayment CreditCardPayment = new CreditCardPayment();
            IPayment PayPalPayment = new PayPalPayment();
            List<IPayment> payments = new List<IPayment>();

            foreach (var payment in payments)
            {
                Console.WriteLine(payment.ProcessPayment(100));
            }

        }


    }
}
