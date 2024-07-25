# Fibonicci Problem 
This solved by Dynammic Programming by two approchs: 
Top-Down Approach
```csharp
      // This Top-Down approach
      public int[] memo = new int[1000]; // to store the 
      int count = 0;
      public int fib(int n)
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
```
Bottom Approach
```csharp
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
```
