using System;
using System.Collections.Generic;

namespace MyMath
{
    public class Operations
    {
        public static int Max(List<int> nums)
        {
            var l = new List<int> (nums);
            var max = l.max();
            if (nums.Count == 0)
            {
                return (0);
            }
            else
            {
                return (max);
            }
        }
    }
}
