using System;
namespace Leetcode
{
    public class _161_相隔为1的编辑距离
    {
        /// <summary>
        /// 长度相等则比较是否只有一位不等
        /// 长度不等（最多差1）则尝试跳过该位检测其余是否全等
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public bool IsOneEditDistance(string s, string t)
        {
            if (s.Length == t.Length)
            {
                var isDirty = false;
                for (var i = 0; i < s.Length; i++)
                {
                    if (s[i] != t[i])
                    {
                        if (isDirty)
                            return false;

                        isDirty = true;
                    }
                }
                return isDirty;
            }

            if (Math.Abs(s.Length - t.Length) > 1)
                return false;

            int si = 0, ti = 0;
            if(s.Length > t.Length)
            {
                var tmp = t;
                t = s;
                s = tmp;
            }

            while (si < s.Length && s[si] == t[ti])
            {
                si++;
                ti++;
            }

            ti++;
            while(si < s.Length && s[si] == t[ti])
            {
                si++;
                ti++;
            }

            return si == s.Length;
        }
    }
}
