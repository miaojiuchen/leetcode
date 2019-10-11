using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Leetcode
{
    /*
        思路
        标签：数组遍历
        首先对数组进行排序，排序后固定一个数 nums[i]，再使用左右指针指向 nums[i]后面的两端，数字分别为 nums[L] 和 nums[R]，计算三个数的和 sum 判断是否满足为 0，满足则添加进结果集
        如果 nums[i]大于 0，则三数之和必然无法等于 0，结束循环
        如果 nums[i] == nums[i-1]，则说明该数字重复，会导致结果重复，所以应该跳过
        当 sum == 0 时，nums[L] == nums[L+1] 则会导致结果重复，应该跳过，L++
        当 sum == 0 时，nums[R] == nums[R-1] 则会导致结果重复，应该跳过，R--
        时间复杂度：O(n^2)

        作者：guanpengchn
        链接：https://leetcode-cn.com/problems/3sum/solution/hua-jie-suan-fa-15-san-shu-zhi-he-by-guanpengchn/
        来源：力扣（LeetCode）
        著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。


        public static List<List<Integer>> threeSum(int[] nums) {
            List<List<Integer>> ans = new ArrayList();
            int len = nums.length;
            if(nums == null || len < 3) return ans;
            Arrays.sort(nums); // 排序
            for (int i = 0; i < len ; i++) {
                if(nums[i] > 0) break; // 如果当前数字大于0，则三数之和一定大于0，所以结束循环
                if( nums[i] == nums[i-1]) continue; // 去重
                int L = i+1;
                int R = len-1;
                while(L < R){
                    int sum = nums[i] + nums[L] + nums[R];
                    if(sum == 0){
                        ans.add(Arrays.asList(nums[i],nums[L],nums[R]));
                        while (L<R && nums[L] == nums[L+1]) L++; // 去重
                        while (L<R && nums[R] == nums[R-1]) R--; // 去重
                        L++;
                        R--;
                    }
                    else if (sum < 0) L++;
                    else if (sum > 0) R--;
                }
            }        
            return ans;
        }
         */
    public class Sum3
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> tps = new List<IList<int>>();

            Array.Sort(nums);

            for (var i = 0; i < nums.Length && nums[i] <= 0; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                    continue;

                var L = i + 1;
                var R = nums.Length - 1;

                while (L < R)
                {
                    var sum = nums[i] + nums[L] + nums[R];
                    if (sum == 0)
                    {
                        tps.Add(new List<int> { nums[i] , nums[L] , nums[R] });
                        while (L < R && nums[L] == nums[L + 1]) L++;
                        while (L < R && nums[R] == nums[R - 1]) R--;
                        L++;
                        R--;
                    }
                    else if (sum < 0)
                        L++;
                    else
                        R--;
                }
            }

            return tps;
        }
    }
}
