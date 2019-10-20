using System;
using System.Collections.Generic;

namespace Leetcode
{
    public class _40_解数独
    {
        private int size;
        private char[][] board;
        private HashSet<int>[] colCheck;
        private HashSet<int>[] rowCheck;
        private HashSet<int>[] subCheck;

        public void SolveSudoku(char[][] _board)
        {
            board = _board;
            size = board.Length;
            colCheck = initArrayOfEmptySet(new HashSet<int>[size]);
            rowCheck = initArrayOfEmptySet(new HashSet<int>[size]);
            subCheck = initArrayOfEmptySet(new HashSet<int>[size]);

            for (var row = 0; row < size; row++)
            {
                for (var col = 0; col < size; col++)
                {
                    var val = board[row][col];
                    var subIndex = (row / 3) * 3 + col / 3;
                    if (val != '.')
                    {
                        var i = val - '0';
                        rowCheck[row].Add(i);
                        colCheck[col].Add(i);
                        subCheck[subIndex].Add(i);
                    }
                }
            }

            solve(0, 0);
        }

        private bool solve(int row, int col)
        {
            if (col == size)
            {
                col = 0;
                row++;
                if (row == size)
                {
                    return true;
                }
            }

            var val = board[row][col];
            var subIndex = (row / 3) * 3 + col / 3;

            if (val != '.')
            {
                return solve(row, col + 1);
            }

            for (var c = '1'; c <= '9'; c++)
            {
                var i = c - '0';
                if (rowCheck[row].Contains(i) || colCheck[col].Contains(i) || subCheck[subIndex].Contains(i))
                {
                    continue;
                }
                rowCheck[row].Add(i);
                colCheck[col].Add(i);
                subCheck[subIndex].Add(i);
                board[row][col] = c;

                var success = solve(row, col + 1);
                if (!success)
                {
                    rowCheck[row].Remove(i);
                    colCheck[col].Remove(i);
                    subCheck[subIndex].Remove(i);
                    board[row][col] = '.';
                    continue;
                }
                return true;
            }

            return false;
        }

        private HashSet<T>[] initArrayOfEmptySet<T>(HashSet<T>[] arr)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                arr[i] = new HashSet<T>();
            }
            return arr;
        }
    }
}
