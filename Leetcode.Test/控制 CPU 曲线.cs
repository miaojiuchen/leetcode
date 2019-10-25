using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Test
{
    class Test_控制_CPU_曲线
    {
        控制_CPU_曲线 C;
        [SetUp]
        public void Setup()
        {
            C = new 控制_CPU_曲线();
        }

        [Test]
        public void Test()
        {
            C.ControlCPU(50);
        }

    }
}
