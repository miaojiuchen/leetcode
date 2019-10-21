using System;
using System.Linq;
using System.Text;

namespace Leetcode
{
    public class _415_字符串相加
    {
        public string AddStrings(string num1, string num2)
        {
            var ans = new StringBuilder();
            int mod = 0;
            int carry = 0;
            var size = Math.Max(num1.Length, num2.Length);
            var factors = new string[] { num1, num2};
            for (var i = 0; i < size; i++)
            {
                var sum = factors.Sum(x =>
                {
                    var idx = x.Length - 1 - i;
                    if (idx < 0)
                    {
                        return 0;
                    }

                    return x[idx] - '0';
                }) + carry;

                mod = sum % 10;
                carry = sum / 10;

                ans.Insert(0, (char)('0' + mod));
            }
            if (carry != 0)
            {
                ans.Insert(0, (char)('0' + carry));
            }
            return ans.ToString();
        }
    }
}
