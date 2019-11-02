using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode
{
    public class _51_N皇后
    {
        private int n;
        private int crossCount;
        private int[] colCheck;
        private bool[] rCrossCheck;
        private bool[] lCrossCheck;

        private List<IList<string>> ans;

        public IList<IList<string>> SolveNQueens(int _n)
        {
            n = _n;
            colCheck = new int[n];
            for (var i = 0; i < n; i++)
            {
                colCheck[i] = -1;
            }

            crossCount = 2 * n - 1;
            rCrossCheck = new bool[crossCount];
            lCrossCheck = new bool[crossCount];

            ans = new List<IList<string>>();
            solve(0);
            return ans;
        }

        private void solve(int row)
        {
            if (row == n)
            {
                ans.Add(BoardToString());
                return;
            }

            for (var col = 0; col < n; col++)
            {
                if (checkAttack(row, col))
                {
                    continue;
                }

                colCheck[col] = row;
                rCrossCheck[rCrossIndex(row, col)] = true;
                lCrossCheck[lCrossIndex(row, col)] = true;
                solve(row + 1);
                colCheck[col] = -1;
                rCrossCheck[rCrossIndex(row, col)] = false;
                lCrossCheck[lCrossIndex(row, col)] = false;
            }
        }

        private bool checkAttack(int row, int col)
        {
            return colCheck[col] != -1 || rCrossCheck[rCrossIndex(row, col)] || lCrossCheck[lCrossIndex(row, col)];
        }

        // rCross 方程： x + y = crossIndex
        private int rCrossIndex(int row, int col)
        {
            return row + col;
        }

        // lCross 方程： x - y = crossIndex - (crossCount 整除 2)
        private int lCrossIndex(int row, int col)
        {
            return row - col + crossCount / 2;
        }

        private List<string> BoardToString()
        {
            var list = new List<string>();
            for (var row = 0; row < n; row++)
            {
                StringBuilder sb = new StringBuilder();
                for (var col = 0; col < n; col++)
                {
                    if (colCheck[col] == row)
                    {
                        sb.Append("Q");
                    }
                    else
                    {
                        sb.Append(".");
                    }
                }
                list.Add(sb.ToString());
            }
            return list;
        }
    }
}
