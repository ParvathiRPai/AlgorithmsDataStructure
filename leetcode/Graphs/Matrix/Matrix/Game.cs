using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public class Solution
    {
        private const char UnrevealedMine = 'M';
        private const char UnrevealedEmpty = 'E';
        private const char RevealedBlank = 'B';
        private const char RevealedMine = 'X';

        public char[,] UpdateBoard(char[,] board, int[] click)
        {
            var cell = board[click[0], click[1]];
            if (cell == UnrevealedMine)
            {
                board[click[0], click[1]] = RevealedMine;
            }
            else
            {
                ClickOnEmptyCell(board, click[0], click[1]);
            }

            return board;
        }

        private void ClickOnEmptyCell(char[,] board, int row, int col)
        {
            var count = GetMineCount(board, row, col);
            if (count > 0)
            {
                board[row, col] = count.ToString()[0];
            }
            else
            {
                board[row, col] = RevealedBlank;
                foreach (var cell in GetAdjacentCells(board, row, col))
                {
                    if (board[cell.Item1, cell.Item2] == UnrevealedEmpty)
                    {
                        ClickOnEmptyCell(board, cell.Item1, cell.Item2);
                    }
                }
            }
        }

        private int GetMineCount(char[,] board, int row, int col)
        {
            return GetAdjacentCells(board, row, col)
                .Count(cell => board[cell.Item1, cell.Item2] == UnrevealedMine);
        }

        private IEnumerable<Tuple<int, int>> GetAdjacentCells(char[,] board, int row, int col)
        {
            for (int rowDelta = -1; rowDelta <= 1; rowDelta++)
            {
                for (int colDelta = -1; colDelta <= 1; colDelta++)
                {
                    if (rowDelta == 0 && colDelta == 0)
                    {
                        continue;
                    }

                    var newRow = row + rowDelta;
                    var newCol = col + colDelta;
                    if (newRow < 0 || newRow >= board.GetLength(0)
                       || newCol < 0 || newCol >= board.GetLength(1))
                    {
                        continue;
                    }
                    else
                    {
                        yield return Tuple.Create(newRow, newCol);
                    }
                }
            }
        }
    }
}
