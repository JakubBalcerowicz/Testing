using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int N) {
        if(N > 0 && N <= int.MaxValue)
        {
            bool status = false;
            string binary = Convert(N);
            char[] charArr = binary.ToCharArray();
            int length = binary.Length;
            int curentLength = 0;
            int maxGap = 0;
            for(int i=0; i < length; i++)
            {
                if(status)
                {
                    if(charArr[i] == '0')
                    {
                        curentLength++;
                        continue;
                    }
                }
                if(status && (charArr[i] == '1'))
                {
                    if(curentLength > maxGap)
                        maxGap = curentLength;
                    curentLength = 0;
                    status = false;
                }
                if(charArr[i] == '1')
                {
                    status = changeStatus(status);
                    continue;
                }
            }
            return maxGap;
        }
        return 0;
    }
    
    public static bool changeStatus(bool currentStatus)
    {
        if(currentStatus)
            return false;
        else
            return true;
    }
    
    public static string Convert(int x) 
    {
      char[] bits = new char[32];
      int i = 0;
    
      while (x != 0) {
        bits[i++] = (x & 1) == 1 ? '1' : '0';
        x >>= 1;
      }
    
      Array.Reverse(bits, 0, i);
      return new string(bits);
    }
}
