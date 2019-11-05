using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode
{
    public class _348_判定井字棋胜负
    {
        public class TicTacToe
        {
            private int[] rowCount;
            private int[] colCount;

            private int leftCrossCount;
            private int rightCrossCount;

            private int _n;


            /** Initialize your data structure here. */
            public TicTacToe(int n)
            {
                _n = n;
                rowCount = new int[n];
                colCount = new int[n];
            }

            /** Player {player} makes a move at ({row}, {col}).
                @param row The row of the board.
                @param col The column of the board.
                @param player The player, can be either 1 or 2.
                @return The current winning condition, can be either:
                        0: No one wins.
                        1: Player 1 wins.
                        2: Player 2 wins. */
            public int Move(int row, int col, int player)
            {
                if (player == 1)
                {
                    rowCount[row]++;
                    colCount[col]++;
                    if (row + col == _n - 1)
                    {
                        rightCrossCount++;
                    }
                    if (row == col)
                    {
                        leftCrossCount++;
                    }

                    if (
                       rowCount[row] == _n ||
                       colCount[col] == _n ||
                       leftCrossCount == _n ||
                       rightCrossCount == _n
                    )
                    {
                        return player;
                    }
                }
                else
                {
                    rowCount[row]--;
                    colCount[col]--;
                    if (row + col == _n - 1)
                    {
                        rightCrossCount--;
                    }
                    if (row == col)
                    {
                        leftCrossCount--;
                    }

                    if (
                       rowCount[row] == -_n ||
                       colCount[col] == -_n ||
                       leftCrossCount == -_n ||
                       rightCrossCount == -_n
                    )
                    {
                        return player;
                    }
                }

                return 0;
            }
        }
    }
}
