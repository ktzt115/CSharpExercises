//6-18 , (Optional, Exercise 1) 
namespace MultiplicationTable
{
    internal class Program
    {
        static public int[,] CreateArray()
        {
            int[,] table = new int[10, 5];
            return table;
        }
        static void Main(string[] args)
        {
            int[,] mathTable = CreateArray();

            Console.Write("{0, 6}", $" ");
            for (int i = 0; i < mathTable.GetLength(1); i++)
            {
                Console.Write("{0, 6}", i);
            }
            Console.WriteLine();

            Console.Write("{0, 6}", $" ");
            for (int i = 0; i < mathTable.GetLength(1); i++)
            {
                Console.Write("{0, 6}", "---");
            }
            Console.WriteLine();

            for (int i = 0; i < mathTable.GetLength(0); i++) // 10
            {

                Console.Write("{0, 6}", $"{i} |");
                for (int j = 0; j < mathTable.GetLength(1); j++) // 5
                {
                    mathTable[i, j] = i * j; // multiplication table
                    Console.Write("{0, 6}", mathTable[i, j]);
                }
                Console.WriteLine();
            }

        }
    }
}