using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Test
{
    class Test_146_LRU缓存
    {
        _146_LRU缓存 c;


        [Test]
        public void Test()
        {
            var cache = new _146_LRU缓存.LRUCache(2);
            var res = new int[5];
            cache.Put(1, 1);
            cache.Put(2, 2);
            res[0] = cache.Get(1);       // 返回  1
            cache.Put(3, 3);    // 该操作会使得密钥 2 作废
            res[1] = cache.Get(2);       // 返回 -1 (未找到)
            cache.Put(4, 4);    // 该操作会使得密钥 1 作废
            res[2] = cache.Get(1);       // 返回 -1 (未找到)
            res[3] = cache.Get(3);       // 返回  3
            res[4] = cache.Get(4);       // 返回  4

            var targets = new int[] { 1, -1, -1, 3, 4 };

            if(res.Except(targets).Count() == 0)
            {
                Assert.Pass();
            } else
            {
                Assert.Fail();
            }
        }
    }
}
