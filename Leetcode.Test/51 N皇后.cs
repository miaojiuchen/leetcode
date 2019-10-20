using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Leetcode.Test
{
    class Test_51_N皇后
    {
        _51_N皇后 C;
        [SetUp]
        public void Setup()
        {
            C = new _51_N皇后();
        }

        [Test]
        public void Test()
        {
            var x = C.SolveNQueens(4);
            foreach (var xx in x)
            {
                Console.WriteLine(xx);
            }
        }
    }
}
