using System.Collections.Generic;
using System.Linq;

namespace CodewarsTest.Alvi
{
    public class Sudoku
    {
        public static bool ValidateSolution(int[][] board)
        {
            //Create three jagged int lists and make sure they have the same size and values of the input array
            List<List<int>> boardList = new List<List<int>>();
            List<List<int>> columnList = new List<List<int>>();
            List<List<int>> blockList = new List<List<int>>();
            for (int y = 0; y < board.Length; y++)
            {
                boardList.Add(board[y].ToList());
                columnList.Add(board[y].ToList());
                blockList.Add(board[y].ToList());
            }


            //Populate the blocklist and the column list with collection values that conform to columns and blocks
            for (int y = 0; y < boardList.Count(); y++)
            {
                for (int x = 0; x < boardList[0].Count(); x++)
                {
                    columnList[x][y] = boardList[y][x];
                    blockList[y][x] = boardList[(y / 3) * 3 + x / 3][x % 3 + (y % 3) * 3];
                }
            }

            //Join the 3 lists together
            var totalList = boardList.Concat(columnList).Concat(blockList);

            //Check if the combined list has any invalid rows, ie: numbers other than 1-9 or duplicate numbers
            foreach (List<int> row in totalList)
            {
                if (row.Any(v => v < 1 || v > 9) || (row.GroupBy(v => v).Any(g => g.Count() > 1)))
                {
                    return false;
                }
            }
            return true;
        }
    }
}


