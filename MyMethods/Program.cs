namespace MyMethods
{
    internal class Program
    {
        //static void MyMethod(string fname)
        //{
        //    Console.WriteLine(fname + " Refsnes");
        //}


        //static void Main(string[] args)
        //{
        //    MyMethod("Liam");
        //    MyMethod("Jenny");
        //    MyMethod("Anja");

        //}


        //static int MyMethod(int x , int y)
        //{
        //    return x + y;
        //}
        //static void Main(string[] args)
        //{
        //    int z = MyMethod(8, 12);
        //    Console.WriteLine("total is :: " + z);
        //}

        static int PlusMethodInt(int x, int y)
        {
            return x + y;
        }
        static double PlusMethodDouble(double x, double y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            int n1 = PlusMethodInt(1, 2);
            double n2 = PlusMethodDouble(7.44, 2.55);
            Console.WriteLine("Int:"+ n1);
            Console.WriteLine("Double:"+ n2);
        }

        //static void MyMethod(string fname, int age)
        //{
        //    Console.WriteLine(fname + " is " + age);
        //}

        //static void Main(string[] args)
        //{
        //    MyMethod("Liam", 5);
        //    MyMethod("Jenny", 8);
        //    MyMethod("Anja", 31);
        //}

    }
}
