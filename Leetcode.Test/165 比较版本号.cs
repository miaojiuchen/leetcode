using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Test
{
    class Test_165_比较版本号
    {
        _165_比较版本号 C;
        [SetUp]
        public void Setup()
        {
            C = new _165_比较版本号();
        }

       
        [Test]
        public void Test1()
        {
            var val = C.CompareVersion("0.1", "1.1");
            if(val == -1)
            {
                Assert.Pass();
            } else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void Test2()
        {
            var val = C.CompareVersion("1.0.1", "1");
            if (val == 1)
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
            var val = C.CompareVersion("7.5.2.4", "7.5.3");
            if (val == -1)
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
            var val = C.CompareVersion("1.01", "1.001");
            if (val == 0)
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
            var val = C.CompareVersion("1.0", "1.0.0");
            if (val == 0)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void Test6()
        {
            var val = C.CompareVersion("0.9.9.9.9.9.9.9.9.9.9.9.9", "0.9.9");
            if (val == 1)
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
