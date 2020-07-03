using System;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        int length = A.Length;
        if(A.Length > 0 && A.Length <= 100000){
        Array.Sort(A);
        if(A[0] > 1000000 || A[0] < -1000000)
            return -1;
        if(A[length - 1] > 1000000)
            return -1;
        HashSet<int> found = new HashSet<int>();
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] > 0)
            {
                found.Add(A[i]);
            }
        }

        int result = 1;
        while (found.Contains(result))
        {
            result++;
        }

        return result;
        }
        return -1;
    }
}
