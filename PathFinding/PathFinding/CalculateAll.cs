using System;

namespace PathFinding
{
    public class CalculateAll
    {
        public static int[,] Calculate()
        {
            const int stopX = 8;
            const int stopY = 3;
            var matrix = new int[255, 255];
            for (int i = 0; i < 255; i++)
            {
                for (int j = 0; j < 255; j++)
                {
                    matrix[i, j] = (int) Math.Sqrt((i - stopX) * (i - stopX) + (j - stopY) * (j - stopY)); ;
                }
            }

            return matrix;
        }
    }
}
