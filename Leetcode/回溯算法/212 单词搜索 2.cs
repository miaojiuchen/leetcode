using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.回溯算法
{
    public class _212_单词搜索_2
    {

        private char[][] _board;
        private int _width;
        private int _height;

        private bool[][] check;
        private Trie trie;

        public IList<string> FindWords(char[][] board, string[] words)
        {
            var trie = new Trie(words);

            check = new bool[_height][];
            for (var i = 0; i < _width; ++i)
            {
                check[i] = new bool[_width];
            }

            for (var i = 0; i < _height; ++i)
            {
                for (var j = 0; i < _width; ++j)
                {
                    exists(0, 0);
                }
            }
        }

        private bool exists(int i, int j)
        {
            check[i][j] = true;


            check[i][j] = false;
            return false;
        }

        private bool inBoard(int i, int j)
        {
            return i >= 0 && i < _height && j >= 0 && j < _width;
        }

        public class Trie
        {
            public struct Node
            {
                internal char c;
                internal Dictionary<char, Node> children;
                internal bool isWord;
            }

            private Dictionary<char, Node> children;
            private bool isWord;

            public Trie(string[] words)
            {
                children = new Dictionary<char, Node>();
                foreach (var w in words)
                {
                    if (w == "")
                    {
                        isWord = true;
                    }
                    else
                    {
                        Insert(w);
                    }
                }
            }

            public void Insert(string s)
            {
                var cur = children;
                var i = 0;
                while (i != s.Length)
                {
                    if (cur.ContainsKey(s[i]))
                    {
                        cur = cur[s[i]].children;
                    }
                    else
                    {
                        cur.Add(s[i], new Node
                        {
                            c = s[i],
                            children = new Dictionary<char, Node>(),
                            isWord = i == s.Length - 1
                        });
                    }
                    ++i;
                }
            }

            public bool ExistsPrefix(string s)
            {
                var cur = children;
                var i = 0;
                while (i != s.Length)
                {
                    if (cur.ContainsKey(s[i]))
                    {
                        cur = cur[s[i]].children;
                        i++;
                    }
                    else
                    {
                        return false;
                    }
                }

                return true;
            }
        }
    }
}
