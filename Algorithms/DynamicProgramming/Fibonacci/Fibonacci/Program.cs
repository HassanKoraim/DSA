﻿using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Top-Down Approach
            
            Program program = new Program();
            Console.WriteLine(fib(6));
            Console.WriteLine($"The # numbers of Calls {count}");
            
            #endregion

            #region Bottom Approach    
            Console.WriteLine(fib2(6));
            #endregion
        }

        // This Top-Down approach
        private static int[] memo = new int[1000]; // to store the 
        static int count = 0;
        public static int fib(int n)
        {
            // manipulate with negative numbers
            if(n < 0) { Console.WriteLine("The negative numbers are not allowed"); return -1; }
            // check we call this before or not 
            if (memo[n] != 0) {Console.WriteLine($"The number in memo[{n}]: {memo[n]}"); return memo[n];} // if Yes return the result of sum this 
            count++; // to count # of calls
            int sum = 0;
            // base case
            if(n == 0) { memo[0] = 0; return 0; }
            if(n == 1) { memo[1] = 1;  return 1; }      
            sum = fib(n - 1) + fib(n - 2);
            // store the result in memo
            memo[n] = sum;
            return sum;
        }

        // This is Bottom Approach
        public static int fib2(int n) 
        {
            int[] memo = new int[1000];
            memo[0] = 0;
            memo[1] = 1;
            for(int i =2; i <=n ; i++)
            {
                memo[i] = memo[i-1] + memo[i-2];
            }
            return memo[n];

        }
    }
   
}
