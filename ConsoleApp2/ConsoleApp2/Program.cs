using System;
using System.Collections.Generic;


namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = new List<int> { 5, 3, 3, 0, 1, 6 };
            var smallests = GetSmallests(nums, 100);
            foreach(var x in smallests)
            {
                Console.WriteLine(x);
            }
        }
        public static List<int> GetSmallests(List<int> nums,int cnt)

        {   if (nums == null)
                throw new ArgumentNullException("list cannot be null");
            if(cnt>nums.Count || cnt<0)
            { throw new ArgumentOutOfRangeException("count", "invalid Count"); }
            var ans = new List<int>();
            if (cnt > 0)
            {   
                cnt = cnt>nums.Count? nums.Count:cnt;
                var temp = new List<int>();
                // or temp = new List<int>(nums);
                temp.AddRange(nums);
                // temp.Sort((x, y) => y.CompareTo(x));
                temp.Sort();
                for (int i = 0; i < cnt; i++)
                {
                    ans.Add(temp[i]);
                }
            }
            return ans;
        }
    }
}
