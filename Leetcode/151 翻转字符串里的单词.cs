using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode
{
    /// <summary>
    /// 首先完全反转字符串
    /// 然后一趟大遍历， 一段空白+单词+单个空格 为一段
    /// 对于每一段，首先尝试平移首段空白，然后翻转该段单词，然后将尾部除了一个空格以外的空白并入下一段
    /// 最后去除所有尾巴空白
    /// </summary>
    public class _151_翻转字符串里的单词
    {
        public string ReverseWords(string s)
        {
            var arr = s.Trim().Reverse().ToArray();

            if (arr.Length == 0)
            {
                return "";
            }

            var i = 0;
            var j = 0;

            while (i < arr.Length)
            {
                tryMove(arr, i, j);

                while (j < arr.Length && arr[j] != ' ')
                {
                    j++;
                }

                swap(arr, i, j - 1);

                i = j + 1;
                j = i;
            }

            return (new string(arr)).TrimEnd();
        }

        private void tryMove(char[] arr, int i, int j)
        {
            while (j < arr.Length && arr[j] == ' ')
            {
                j++;
            }

            // 平移多余空格
            if (j - i > 1)
            {
                var k = j;
                while (k < arr.Length && arr[k] != ' ')
                {
                    k++;
                }
                move(arr, i, j, k);
            }
        }

        private void move(char[] arr, int i, int j, int k)
        {
            while (j < k)
            {
                arr[i] = arr[j];
                i++;
                j++;
            }
            var h = i;
            while (h < k)
            {
                arr[h] = ' ';
                h++;
            }
        }

        private void swap(char[] arr, int i, int j)
        {
            while (j > i)
            {
                var tmp = arr[i];
                arr[i] = arr[j];
                arr[j] = tmp;
                j--;
                i++;
            }
        }
    }
}
