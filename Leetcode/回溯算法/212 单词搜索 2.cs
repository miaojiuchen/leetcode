using System;
using System.Collections.Generic;
using System.IO;
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
        private List<string> ans;

        public IList<string> FindWords(char[][] board, string[] words)
        {
            ans = new List<string>();

            if (words.Length == 0)
            {
                return ans;
            }

            _board = board;
            _height = board.Length;
            _width = board[0].Length;

            trie = new Trie(words);

            check = new bool[_height][];
            for (var i = 0; i < _height; ++i)
            {
                check[i] = new bool[_width];
            }

            for (var i = 0; i < _height; ++i)
            {
                for (var j = 0; j < _width; ++j)
                {
                    exists(i, j, trie);
                }
            }

            return ans.Distinct().ToList();
        }

        private void exists(int i, int j, Trie cur)
        {
            if(!inBoard(i, j) || check[i][j])
            {
                return;
            }
            var c = _board[i][j];
            if (!cur.children.ContainsKey(c))
            {
                return;
            }

            check[i][j] = true;

            var node = cur.children[c];

            if (node.isWord)
            {
                ans.Add(node.val);
            }

            exists(i + 1, j, node);
            exists(i - 1, j, node);
            exists(i, j + 1, node);
            exists(i, j - 1, node);

            check[i][j] = false;
        }

        private bool inBoard(int i, int j)
        {
            return i >= 0 && i < _height && j >= 0 && j < _width;
        }

        public class Trie
        {
            public Dictionary<char, Trie> children;
            public bool isWord;
            public char c;
            public string val;

            public Trie(char _c, bool _isWord)
            {
                children = new Dictionary<char, Trie>();
                c = _c;
                isWord = _isWord;
            }

            public Trie(string[] words)
            {
                children = new Dictionary<char, Trie>();
                foreach (var w in words)
                {
                    if (w == "")
                    {
                        isWord = true;
                        val = w;
                    }
                    else
                    {
                        Insert(w);
                    }
                }
            }

            public void Insert(string s)
            {
                var cur = this;
                var i = 0;
                while (i != s.Length)
                {
                    if (!cur.children.ContainsKey(s[i]))
                    {
                        cur.children.Add(s[i], new Trie(s[i], false));
                    }

                    cur = cur.children[s[i]];
                    ++i;
                }

                cur.isWord = true;
                cur.val = s;
            }
        }
    }
}
