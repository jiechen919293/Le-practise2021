using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2021
{
    class Leetcode277findcelebrity_2_
    {
        public static bool knows(int x, int i)
        {
            return true;
        }
        public int findCelebrity(int n)
        {
            for (int i = 0; i < n; ++i)
            {
                bool isCelebrity = true;
                for (int j = 0; j < n; ++j)
                {
                    if (j == i) continue;
                    if (knows(i, j) || !knows(j, i))
                    {
                        isCelebrity = false;
                        break;
                    }
                }
                if (isCelebrity)
                    return i;
            }
            return -1;
        }
 }
}
