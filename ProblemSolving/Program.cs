using System.Linq;

namespace ProblemSolving
{

    public class Program
    {
        #region first program MIn Max of Array

        public static double[] FindMinMax(double[] values)
        {
            if (values == null || values.Length == 0)
                throw new ArgumentException("Array cannot be null or empty.");

            double min = values.Min();
            double max = values.Max();

            return new double[] { min, max };
        }
        #endregion

        public static T GetFirstElement<T>(T[] array)
        {
            if(array == null || array.Length == 0)
            {
                throw new ArgumentException("Array cannot be null or empty.");
            }
            return array[0];
        }
        public static T GetLastElement<T>(T[] array)
        {
            if(array == null || array.Length == 0)
            {
                throw new ArgumentException("Array cannot be null or empty.");
            }
            return array[array.Length - 1]; ;
        }
        public static (int min, int max, int diff) DiffMinMax(int[] arraydiff)
        {
             if (arraydiff == null || arraydiff.Length == 0)
            {
                throw new ArgumentException("Array cannot be null or empty.");
            }
            int arraymin = arraydiff.Min();
            int arraymax = arraydiff.Max();
            int arraydiffMinMax = arraymax - arraymin;
            return (arraymin,arraymax,arraydiffMinMax);
        }


        public interface ITestpaper
        {
            string Subject { get; }
            string[] MarkScheme { get; }
            string PassMark { get; }
        }

        public class Testpaper : ITestpaper
        {
            public string Subject { get; }
            public string[] MarkScheme { get; }
            public string PassMark { get; }

            public Testpaper(string subject, string[] markScheme, string passMark)
            {
                Subject = subject;
                MarkScheme = markScheme;
                PassMark = passMark;
            }
        }

        public interface IStudent
        {
            string[] TestsTaken { get; }
            void TakeTest(ITestpaper paper, string[] answers);
        }

        public class Student : IStudent
        {
            private List<string> testsTaken;

            public Student()
            {
                testsTaken = new List<string>();
            }

            public string[] TestsTaken
            {
                get
                {
                    return testsTaken.Count == 0 ? new string[] { "No tests taken" } : testsTaken.ToArray();
                }
            }

            public void TakeTest(ITestpaper paper, string[] answers)
            {
                int correctAnswers = paper.MarkScheme.Zip(answers, (key, answer) => key == answer ? 1 : 0).Sum();
                double scorePercentage = ((double)correctAnswers / paper.MarkScheme.Length) * 100;

                int passThreshold = int.Parse(paper.PassMark.TrimEnd('%'));

                string result = scorePercentage >= passThreshold ? "Passed!" : "Failed!";
                testsTaken.Add($"{paper.Subject}: {result} ({scorePercentage:F0}%)");
            }
        }
        public static void Main()
        {
            double[] numbers = { 3.5, 1.2, 7.8, 9.1, 2.3, 8.4 };
            double[] result = FindMinMax(numbers);
            Console.WriteLine("First Program");
            Console.WriteLine($"Min: {result[0]}, Max: {result[1]}");
            Console.WriteLine("================================");
            Console.WriteLine("Second Program");
            int[] numbers2 = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine($"first element is: {GetFirstElement(numbers2)}");
            Console.WriteLine($"Last element is: {GetLastElement(numbers2)}");
            string[] words = { "apple", "banana", "cherry"};
            Console.WriteLine($"first element in array is:{GetFirstElement(words)}");
            Console.WriteLine($"Last element in array is:{GetLastElement(words)}");
            Console.WriteLine("================================");
            Console.WriteLine("================================");
            int[] arrayNumbers = { 10, 2, 30, 44, 15, 16 };
            Console.WriteLine(DiffMinMax(arrayNumbers));
            Console.WriteLine($"Min:{DiffMinMax(arrayNumbers).min}");
            Console.WriteLine($"Max: { DiffMinMax(arrayNumbers).max}");
            Console.WriteLine($"Diff:{DiffMinMax(arrayNumbers).diff}");
            Console.WriteLine("================================");
            Console.WriteLine("================================");
            Console.WriteLine("Third Program");
            Testpaper paper1 = new Testpaper("Maths", new string[] { "1A", "2C", "3D", "4A", "5A" }, "60%");
            Testpaper paper2 = new Testpaper("Chemistry", new string[] { "1C", "2C", "3D", "4A" }, "75%");
            Testpaper paper3 = new Testpaper("Computing", new string[] { "1D", "2C", "3C", "4B", "5D", "6C", "7A" }, "75%");

            Student student1 = new Student();
            Student student2 = new Student();

            Console.WriteLine(string.Join(", ", student1.TestsTaken)); 

            student1.TakeTest(paper1, new string[] { "1A", "2D", "3D", "4A", "5A" });
            Console.WriteLine(string.Join(", ", student1.TestsTaken)); 

            student2.TakeTest(paper2, new string[] { "1C", "2D", "3A", "4C" });
            student2.TakeTest(paper3, new string[] { "1A", "2C", "3A", "4C", "5D", "6C", "7B" });
            Console.WriteLine(string.Join(", ", student2.TestsTaken)); 


        }






    }

}
