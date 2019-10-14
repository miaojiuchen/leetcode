using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Leetcode.Test
{
    public class Test_241_为运算表达式设计优先级
    {
        _241_为运算表达式设计优先级 C;
        [SetUp]
        public void Setup()
        {
            C = new _241_为运算表达式设计优先级();
        }

        [Test]
        public void Test()
        {
            var x = C.DiffWaysToCompute("2*3-4*5");
            var arr = x.ToArray();
            Array.Sort(arr);
            var target = new List<int> { -34, -14, -10, -10, 10 };
            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i] != target[i])
                {
                    Assert.Fail();
                }
            }
            Assert.Pass();
        }
    }
}
