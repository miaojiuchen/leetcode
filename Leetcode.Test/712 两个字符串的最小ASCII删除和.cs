using System;
using NUnit.Framework;

namespace Leetcode.Test
{
	public class Test_712_两个字符串的最小ASCII删除和
	{
		_712_两个字符串的最小ASCII删除和 C;
		[SetUp]
		public void Setup()
		{
			C = new _712_两个字符串的最小ASCII删除和();
		}

		[Test]
		public void Test()
		{
			var x = C.MinimumDeleteSum("sea", "eat");
			if (x == 231)
				Assert.Pass();
			else
				Assert.Fail();
		}

		[Test]
		public void Test2()
		{
			var x = C.MinimumDeleteSum("delete", "leet");
			if (x == 403)
				Assert.Pass();
			else
				Assert.Fail();
		}
	}
}
