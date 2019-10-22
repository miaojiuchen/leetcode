using System;
using System.Collections.Generic;

namespace Leetcode
{
    public class _339_嵌套列表权重和
    {
        public interface NestedInteger
        {
            bool IsInteger();

            int GetInteger();

            IList<NestedInteger> GetList();
        }

        public int DepthSum(IList<NestedInteger> nestedList)
        {
            return depthSum(nestedList, 1);
        }

        private int depthSum(IList<NestedInteger> nestedList, int depth)
        {
            if (nestedList == null)
            {
                return 0;
            }
            var sum = 0;
            foreach (var nl in nestedList)
            {
                if (nl.IsInteger())
                {
                    sum += nl.GetInteger() * depth;
                }
                else
                {
                    sum += depthSum(nl.GetList(), depth + 1);
                }
            }
            return sum;
        }
    }
}
