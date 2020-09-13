using System.Collections.Generic;
using System.Linq;

namespace CodewarsTest.Alvi
{
    public class ConwayLife
    {
        public static int[,] GetGeneration(int[,] cells, int generation)
        {
            if (generation == 0) { return cells; }
            int currentGen = 0;
            int res = 7;

            int worldSizeR = (cells.GetUpperBound(0) + 1) * res;
            int worldSizeC = (cells.GetUpperBound(1) + 1) * res;

            int[,] latestCells = new int[worldSizeR, worldSizeC];

            for (int r = 0; r <= cells.GetUpperBound(0); r++)
            {
                for (int c = 0; c <= cells.GetUpperBound(1); c++)
                {
                    latestCells[r + res, c + res] = cells[r, c];
                }
            }

            while (currentGen != generation)
            {
                int[,] tempNewGen = (int[,])latestCells.Clone();

                for (int r = 0; r < worldSizeR; r++)
                {
                    for (int c = 0; c < worldSizeC; c++)
                    {
                        int aliveCount = AliveNeighborCount(latestCells, r, c);
                        bool isAlive = false;

                        if (latestCells[r, c] > 0)
                            isAlive = true;
                        else
                            isAlive = false;

                        if (isAlive)
                        {
                            if (aliveCount < 2 || aliveCount > 3)
                                tempNewGen[r, c] = 0;
                            else
                                tempNewGen[r, c] = 1;
                        }
                        else
                        {
                            if (aliveCount == 3)
                                tempNewGen[r, c] = 1;
                            else
                                tempNewGen[r, c] = 0;
                        }

                    }
                }
                currentGen++;
                latestCells = (int[,])tempNewGen.Clone();
            }

            latestCells = CropArray(latestCells);

            return latestCells;
        }

        private static int AliveNeighborCount(int[,] cells, int rInd, int cInd)
        {
            List<int> neighbors = new List<int>();

            for (int i = 0; i < 8; i++)
            {
                int r = 0;
                int c = 0;

                switch (i)
                {
                    case 0: r = rInd - 1; c = cInd - 1; break;
                    case 1: r = rInd - 1; c = cInd; break;
                    case 2: r = rInd - 1; c = cInd + 1; break;
                    case 3: r = rInd; c = cInd - 1; break;
                    case 4: r = rInd; c = cInd + 1; break;
                    case 5: r = rInd + 1; c = cInd - 1; break;
                    case 6: r = rInd + 1; c = cInd; break;
                    case 7: r = rInd + 1; c = cInd + 1; break;
                    default: break;
                }

                if (r > cells.GetUpperBound(0) || c > cells.GetUpperBound(1) || r < 0 || c < 0)
                    neighbors.Add(0);

                else
                    neighbors.Add(cells[r, c]);
            }
            return neighbors.Where(n => n > 0).Count();
        }

        private static int[,] CropArray(int[,] cells)
        {
            int rowMin = cells.GetUpperBound(0);
            int rowMax = 0;
            int columnMin = cells.GetUpperBound(1);
            int columnMax = 0;

            for (int r = 0; r <= cells.GetUpperBound(0); r++)
            {
                for (int c = 0; c <= cells.GetUpperBound(1); c++)
                {
                    int value = cells[r, c];

                    if (value > 0)
                    {
                        if (r < rowMin) { rowMin = r; }
                        if (r > rowMax) { rowMax = r; }
                        if (c < columnMin) { columnMin = c; }
                        if (c > columnMax) { columnMax = c; }
                    }
                }
            }

            if (rowMin > rowMax || columnMin > columnMax) { return new int[0, 0]; }

            int[,] result = new int[rowMax - rowMin + 1, columnMax - columnMin + 1];

            for (int r = 0; r <= result.GetUpperBound(0); r++)
            {
                for (int c = 0; c <= result.GetUpperBound(1); c++)
                {
                    result[r, c] = cells[r + rowMin, c + columnMin];
                }
            }

            return result;
        }

    }
}


