using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestIntegerNotInArray
{
    class Solution
    {
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            HashSet<int> numbersInA = new HashSet<int>();
            foreach (var item in A)
            {
                if (item > 0)
                {
                    numbersInA.Add(item);
                }
            }

            bool foundMissing = false;
            int value = 1;
            while(!foundMissing)
            {
                if (!numbersInA.Contains(value))
                {
                    foundMissing = true;
                }
                else
                {
                    value++;
                }
            }
            return value;

        }
    }
}
