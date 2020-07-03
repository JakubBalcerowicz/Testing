using System;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int[] solution(int[] A, int K) {
        int[] validElements = new int[A.Length];
        Array.Sort(validElements);
         if(validElements[0] > 1000 || validElements[0] < -1000)
            return A;
        if(validElements[A.Length - 1] > 1000)
            return A;
        if(A.Length <= 100 && A.Length >= 0 && K <= 100 && K >= 0){
            int[] copied = new int[A.Length];
            Array.Copy(A, copied, A.Length);
            Array.Copy(A, copied, A.Length);
            for(int i =0; i < A.Length; i++)
            {
                copied[(i+K)%A.Length] = A[i];
            }
            return copied;
        }
        return A;
    }
}
