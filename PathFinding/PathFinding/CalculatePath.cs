using System;

namespace PathFinding
{
    public class CalculatePath
    {
        public static int[,] Calculate()
        {
            int startX = 1;
            int startY = 1;
            int stopX = 8;
            var stopY = 3;
            var selectedX = new int[255];
            var selectedY = new int[255];
            var matrix = new int[255, 255];
            for (int i = 0; i < 255; i++)
            {
                for (int j = 0; j < 255; j++)
                {
                    matrix[i, j] = 255;
                }
            }

            bool pathFound = false;
            int z = 0;
            selectedX[z] = startX;
            selectedY[z] = startY;
            while (!pathFound)
            {
                double lowest = 255;
                int bestX = selectedX[z];
                int bestY = selectedY[z];
                for (int i = -1; i <= 1; i++)
                {
                    for (int j = -1; j <= 1; j++)
                    {
                        if (i != 0 || j != 0)
                        {
                            if (selectedX[z] + i >= 0 && selectedY[z] + j >= 0 && matrix[selectedX[z] + i, selectedY[z] + j] == 255)
                            {
                                double distance = Math.Sqrt((selectedX[z] + i - stopX) * (selectedX[z] + i - stopX) + (selectedY[z] + j - stopY) * (selectedY[z] + j - stopY));
                                matrix[selectedX[z] + i, selectedY[z] + j] = (int)Math.Sqrt((selectedX[z] + i - stopX) * (selectedX[z] + i - stopX) + (selectedY[z] + j - stopY) * (selectedY[z] + j - stopY));
                                     
                                if (distance < lowest)
                                {
                                    lowest = distance;
                                    bestX = selectedX[z] + i;
                                    bestY = selectedY[z] + j;
                                }
                            }
                        }
                    }
                }

                z += 1;
                selectedX[z] = bestX;
                selectedY[z] = bestY;
                matrix[bestX, bestY] = matrix[bestX, bestY] * -1;
                if (selectedX[z] == stopX && selectedY[z] == stopY)
                {
                    pathFound = true;
                }
            }

            return matrix;
        }
    }
}
