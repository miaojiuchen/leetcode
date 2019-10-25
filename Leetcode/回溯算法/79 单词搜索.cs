using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.回溯算法
{
    public class _79_单词搜索
    {
        private char[][] _board;
        private int _width;
        private int _height;
        private string _word;
        private bool[][] _check;

        public bool Exist(char[][] board, string word)
        {
            if (board.Length == 0)
            {
                return word.Length == 0;
            }

            _board = board;
            _height = board.Length;
            _width = board[0].Length;
            _word = word;
            _check = new bool[_height][];
            for (var i = 0; i < _height; ++i)
            {
                _check[i] = new bool[_width];
            }

            for (var i = 0; i < _height; i++)
            {
                for (var j = 0; j < _width; ++j)
                {
                    if (exists(i, j, 0))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private bool exists(int i, int j, int ci)
        {
            _check[i][j] = true;

            if (_board[i][j] == _word[ci])
            {
                if (ci == _word.Length - 1)
                {
                    return true;
                }

                // 上
                if (inBoard(i - 1, j) && !_check[i - 1][j])
                {
                    if (exists(i - 1, j, ci + 1))
                    {
                        return true;
                    }
                }

                // 下
                if (inBoard(i + 1, j) && !_check[i + 1][j])
                {
                    if (exists(i + 1, j, ci + 1))
                    {
                        return true;
                    }
                }

                // 左
                if (inBoard(i, j - 1) && !_check[i][j - 1])
                {
                    if (exists(i, j - 1, ci + 1))
                    {
                        return true;
                    }
                }

                // 右
                if (inBoard(i, j + 1) && !_check[i][j + 1])
                {
                    if (exists(i, j + 1, ci + 1))
                    {
                        return true;
                    }
                }
            }

            _check[i][j] = false;

            return false;
        }

        private bool inBoard(int i, int j)
        {
            return i >= 0 && i < _height && j >= 0 && j < _width;
        }
    }
}
