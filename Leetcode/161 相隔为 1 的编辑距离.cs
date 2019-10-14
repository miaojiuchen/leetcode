using System;
namespace Leetcode
{
    public class _161_相隔为1的编辑距离
    {
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
