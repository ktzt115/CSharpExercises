//6-13 , Exercise 1

namespace StatisticsManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] scores = new double[] {2, 5, 3,2, 2 ,43, 2 };
            Console.WriteLine($"Average is {GetAverage(scores)}");
            Console.WriteLine($"Mean is {GetMean(scores)}");
            Console.WriteLine($"Largest Value is {GetLargestValue(scores)}");
            Console.WriteLine($"Smallest Value is {GetSmallestValue(scores)}");
        }

        public static double GetAverage(double[] scores)
        {
            return scores.Average();
        }
        public static double GetMean(double[] scores)
        {
            double sum = 0;
            foreach (double score in scores)
            {
                sum += score;
            }
            return sum/ scores.Length;
        }
        public static double GetLargestValue(double[] scores)
        {
            return scores.Max();
        }
        public static double GetSmallestValue(double[] scores)
        {
            return scores.Min();
        }
    }
}