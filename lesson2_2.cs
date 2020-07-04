using System;
using System.Linq;

class Solution {
    public int solution(int[] A) {
           if (length % 2 == 1 && length < 1000000 && length > 0)
            {
                if (A[0] > 0 && A[0] < 1000000000 && A[length - 1] < 1000000000)
                {
                  return A.GroupBy(n => n).Where(g => g.Count() % 2 == 1).Select(g => g.Key).Single();
                }
            }
    }
}
