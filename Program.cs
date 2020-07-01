using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { -1, 3, -4, 5, 1, -6, 2, 1 };
            int n = arr.Length;
            if (n == 0)
            {
                Console.WriteLine("N need to be greater then 0");
                return;
            }
            Console.WriteLine($"Equilibrium Index:{FindEquilibriumIndex(arr, n)}");
        }

        static private int FindEquilibriumIndex(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                int sumLeft = 0;
                int sumRight = 0;
                for(int k = 0; k < i; k++)
                {
                    sumLeft += arr[k];
                }
                for (int k = i + 1; k < n; k++)
                {
                    sumRight += arr[k];
                }
                if (i == 0 && sumRight == 0)
                    return i;
                if (i == n - 1 && sumLeft == 0)
                    return i;
                if (sumLeft == sumRight)
                    return i;
            }
            return -1;
        }
    }
}
