using PathFinding;
using System;

namespace MapWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrix = CalculatePath.Calculate();
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    Console.Write(matrix[j, i] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
