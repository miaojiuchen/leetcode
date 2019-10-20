using System;
using System.Collections.Generic;

namespace Leetcode
{
    public class _36_有效的数独
    {
        public bool IsValidSudoku(char[][] board)
        {
            const int size = 9;
            var subSudokuCheck = initArrayOfEmptySet(new HashSet<char>[size]);
            var columnCheck = initArrayOfEmptySet(new HashSet<char>[size]);
            var rowCheck = initArrayOfEmptySet(new HashSet<char>[size]);

            for (var row = 0; row < size; row++)
            {
                for (var col = 0; col < size; col++)
                {
                    var val = board[row][col];
                    if (val == '.')
                    {
                        continue;
                    }
                    var subSudokuIndex = (row / 3) * 3 + col / 3;
                    if (
                        rowCheck[row].Contains(val) ||
                        columnCheck[col].Contains(val) ||
                        subSudokuCheck[subSudokuIndex].Contains(val)
                        )
                    {
                        return false;
                    }

                    rowCheck[row].Add(val);
                    columnCheck[col].Add(val);
                    subSudokuCheck[subSudokuIndex].Add(val);
                }
            }

            return true;
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
