using Leetcode.回溯算法;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Leetcode.Test.回溯
{
    public class Test_212_单词搜索_2
    {
        _212_单词搜索_2 c;

        [SetUp]
        public void Setup()
        {
            c = new _212_单词搜索_2();
        }


        [Test]
        public void Test()
        {
            var board = new char[][]
            {
                new char[]{'o','a','a','n' },
                new char[]{ 'e','t','a','e'},
                new char[]{'i','h','k','r' },
                new char[]{'i','f','l','v' },
            };

            var words = new string[] { "oath", "pea", "eat", "rain" };
            var fwords = c.FindWords(board, words);

            var targets = new string[] { "oath", "eat" };

            if (fwords.Intersect(targets).Count() == targets.Count())
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }

        }

        [Test]
        public void Test2()
        {
            var board = new char[][]
            {
                new char[]{'a'},
            };

            var words = new string[] { };
            var fwords = c.FindWords(board, words);
            if (fwords.Count == 0)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void Test3()
        {
            var board = new char[][]
            {
                new char[]{'a', 'a'},
            };

            var words = new string[] { "a" };
            var fwords = c.FindWords(board, words);

            if (fwords.Count == 1 && fwords[0] == "a")
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void Test4()
        {
            var board = new char[][]
            {
                new char[]{'a', 'a'},
            };

            var words = new string[] { "aa" };
            var fwords = c.FindWords(board, words);

            if (fwords.Count == 1 && fwords[0] == "aa")
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void Test5()
        {
            var board = new char[][]
            {
                new char[]{'a', 'b'},
                new char[]{'a', 'a'},
            };

            var words = new string[] { "aba", "baa", "bab", "aaab", "aaa", "aaaa", "aaba" };
            var fwords = c.FindWords(board, words);

            var target = new string[] { "aaa", "aaab", "aaba", "aba", "baa" };

            if (fwords.Intersect(target).Count() == target.Count())
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}
