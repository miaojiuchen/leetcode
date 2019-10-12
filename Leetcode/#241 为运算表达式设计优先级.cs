using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace Leetcode
{
    public class _241_为运算表达式设计优先级
    {
        public IList<int> DiffWaysToCompute(string input)
        {
            IList<int> res = new List<int>();

            for (var i = 0; i < input.Length; i++)
            {
                if (new char[] { '+', '-', '*' }.Contains(input[i]))
                {
                    var res1 = DiffWaysToCompute(input.Substring(0, i));
                    var res2 = DiffWaysToCompute(input.Substring(i + 1));

                    foreach (var l in res1)
                    {
                        foreach (var r in res2)
                        {
                            switch (input[i])
                            {
                                case '+':
                                    res.Add(l + r);
                                    break;
                                case '-':
                                    res.Add(l - r);
                                    break;
                                case '*':
                                    res.Add(l * r);
                                    break;
                            }
                        }
                    }
                }
            }

            if (res.Count == 0)
                res.Add(int.Parse(input));

            return res;
        }
    }
}
