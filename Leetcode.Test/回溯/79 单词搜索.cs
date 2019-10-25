using Leetcode.回溯算法;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Test.回溯
{
    public class Test_79_单词搜索
    {
        _79_单词搜索 c;

        [SetUp]
        public void Setup()
        {
            c = new _79_单词搜索();
        }


        [Test]
        public void Test()
        {
            var board = new char[][]
            {
                new char[]{'A','B','C','E' },
                new char[]{ 'S','F','C','S'},
                new char[]{'A','D','E','E' },
            };

            var res1 = c.Exist(board, "ABCCED");
            var res2 = c.Exist(board, "SEE");
            var res3 = c.Exist(board, "ABCB");

            if (res1 == true && res2 == true && res3 == false)
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
