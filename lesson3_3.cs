using System;
// using System.Collections.Generic;
class Solution 
{
    public int solution(int[] A) 
    {
        // write your code in C# with .NET 2.0
        int sumRight = 0;
        for(int i=0; i<A.Length; i++)
        {
            sumRight += A[i];
        }

        int sumLeft = 0;
        int min = int.MaxValue;
        for(int P=1; P<A.Length; P++)
        {
            int currentP = A[P-1];
            sumLeft += currentP;
            sumRight -= currentP;

            int diff = Math.Abs(sumLeft - sumRight);
            if(diff < min)
            {
                min = diff;
            }
        }
        return min;
    }
}
