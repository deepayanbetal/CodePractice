using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice.Leetcode
{
    internal class TotalStep
    {
        public int check(int[] nums)
        {
            int ans = 0;
            var x = new List<KeyValuePair<int, int>>();
            var ax = new Stack<KeyValuePair<int, int>>();

            for(int i=nums.Length-1; i>=0; i--)
            {
                if (ax.Count == 0)
                    ax.Push(new KeyValuePair<int, int>(nums[i], 0));
                else
                {
                    int a = 0;
                    while(ax.Count()!=0 && ((ax.Select(k=>k.Key).FirstOrDefault())<nums[i]))
                    {
                       //a = Math.Max((a+1),ax.Peek());
                        ax.Pop();
                    }
                    ax.Push(new KeyValuePair<int, int>(nums[i],a));
                    ans = Math.Max(ans,a);
                }
            }
            return ans;
        }
    }
}
