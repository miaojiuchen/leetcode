using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode
{
    public class _43_字符串相乘
    {
        public string Multiply(string num1, string num2)
        {
            if (num1 == "0" || num2 == "0")
            {
                return "0";
            }

            if (num1.Length < num2.Length)
            {
                var tmp = num1;
                num1 = num2;
                num2 = tmp;
            }

            var factors = new string[num2.Length];
            var last = 0;
            for (var i = num2.Length - 1; i >= 0; i--)
            {
                var val = num2[i] - '0';
                var k = 0;
                var carry = 0;
                var tmp = new StringBuilder();
                for (var j = num1.Length - 1; j >= 0; j--)
                {
                    var val2 = num1[j] - '0';
                    var mul = val * val2 + carry;
                    var mod = mul % 10;

                    tmp.Insert(0, (char)('0' + mod));

                    carry = mul / 10;
                    k++;
                }
                if (carry != 0)
                {
                    tmp.Insert(0, (char)('0' + carry));
                }

                var appendZero = num2.Length - 1 - i;

                factors[num2.Length - 1 - i] = tmp.ToString() + repeat("0", appendZero);

                last = factors[num2.Length - 1 - i].Length;
            }

            return sumAns(factors, last);
        }

        private string sumAns(string[] factors, int size)
        {
            var ans = new StringBuilder();
            int mod = 0;
            int carry = 0;
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

        private int pow(int a, int b)
        {
            return Convert.ToInt32(Math.Pow(Convert.ToDouble(a), Convert.ToDouble(b)));
        }

        private string repeat(string c, int count)
        {
            var res = "";
            while (count > 0)
            {
                res += c;
                count--;
            }

            return res;
        }
    }
}
