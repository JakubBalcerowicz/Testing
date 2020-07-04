using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        if(A.Length >=0 && A.Length <= 100000)
        {
            if(A.Length == 0)
                return 1;
            if(A.Length == 1 && A[0] == 1)
                return 2;
            if(A.Length == 1 && A[0] > 1)
                return 1;
                
            int maxValue = A.Max();
            if(maxValue <= A.Length +1)
            {
               return getMissingNo(A,A.Length);
            }
        }
        return -1;
    }
    static int getMissingNo(int[] a, int n) 
        { 
            int total = (n + 1) * (n + 2) / 2; 
      
            for (int i = 0; i < n; i++) 
                total -= a[i]; 
      
            return total; 
        } 
}
