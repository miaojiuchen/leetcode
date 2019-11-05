using Leetcode.动态规划;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Test
{
    class Test_174_地下城游戏
    {
        _174_地下城游戏 c;

        [SetUp]
        public void Setup()
        {
            c = new _174_地下城游戏();
        }


        [Test]
        public void Test()
        {
            var board = new int[][]
            {
                new int[]{-2, -3, 3 },
                new int[]{ -5, -10,  1},
                new int[]{ 10, 30, -5 },
            };

            var res = c.CalculateMinimumHP(board);

            if (res == 7)
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
            var board = new int[][]
            {
                new int[]{ 1,-3,3 },
                new int[]{ 0,-2,0 },
                new int[]{ -3,-3,-3 },
            };

            var res = c.CalculateMinimumHP(board);

            if (res == 3)
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
