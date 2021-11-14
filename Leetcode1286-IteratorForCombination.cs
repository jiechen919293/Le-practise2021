using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2021
{
    class Leetcode1286_IteratorForCombination
    {
        public CombinationIterator(string characters, int combinationLength)
        {
            var s = characters;
            var bits = (1 << s.Length) - 1;
            
        }
        public int Count(int n)
        {
            int count = 0;
            while (n)
            {
                count++;
                n = n & (n - 1);
            }
            return count;
        }
        public string Next()
        {

        }

        public bool HasNext()
        {

        }
    }
}
