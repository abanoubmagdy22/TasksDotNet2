namespace CalculateWhiteSpaces
{
    internal class Program
    {

         static int ClacWhiteSpaces(string value)
        {
            int spaceCountOfString = 0;
            for(int i =0;i < value.Length;i++) 
            {
                if (value[i] == ' ')
                {
                    spaceCountOfString++;
                }
            }
            return spaceCountOfString; 
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string:");
            string x = Console.ReadLine();
            int numofSpaces = ClacWhiteSpaces(x);
            Console.WriteLine("the number of spaces is : " + numofSpaces);
        }
    }
}
