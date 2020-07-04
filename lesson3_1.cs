using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int X, int Y, int D) {
         if(X > 0 && X <= 1000000000 &&
            Y > 0 && Y <= 1000000000 &&
            D > 0 && D <= 1000000000 &&
            X <= Y)
            {
                int jumpCount = 0;
                double distance = Y - X;
                double jump = D;
                int result = (int)Math.Ceiling(distance/jump);
                return result;
            }
        return -1;  
    }
}
