namespace Next_Greater_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            long[] arr = { 1, 3, 2, 4 };
            long[] result = next3(arr, 4);
            foreach (long i in result) {
                Console.WriteLine(i);
            }
            //Console.WriteLine(nextLargerElement(arr, 4));
        }
        #region Last solution from chat Gpt
        public static long[] next3(long[] arr, int n)
        {
            long[] result = new long[n];
            Stack<long> stack = new Stack<long>();

            // Traverse the array from right to left
            for (int i = n - 1; i >= 0; i--)
            {
                // Remove elements from the stack that are smaller or equal to the current element
                while (stack.Count > 0 && stack.Peek() <= arr[i])
                {
                    stack.Pop();
                }

                // If stack is empty, no greater element exists, otherwise the top of the stack is the next greater element
                result[i] = stack.Count == 0 ? -1 : stack.Peek();

                // Push the current element onto the stack
                stack.Push(arr[i]);
            }
            return result;
        }
        #endregion

        #region second Solution
        public static long[] nextLargerElement2(long[] arr, int n)
        {
            long[] result = new long[n];
            result[n - 1] = -1;
            long top;
            for (int i = n-1; i > 0; i--)
            {
                top = arr[i];
                //long temp;
                if(top > arr[i-1])
                {
                   // temp = top;
                    result[i - 1] = top;
                    //result[i - 1] = result[i];
                }
                else
                {
                    int flag = 0;
                    for(int j = i-1; j < n-1; j++)
                    {
                        if (result[j] > arr[i - 1])
                        {
                            result[i-1] = result[j];
                            flag = 1;
                            break;
                        }
                    }
                    if(flag == 0) result[i - 1] = -1;
                }
            }          
            return result;
        }
        #endregion

        #region firstSolution
        public static long[] nextLargerElement(long[] arr, int n)
        {

            // Your code here
            // ArrStack arrStack = new ArrStack(n,arr);
            long[] result = new long[n];
            long top;
            if(n == 0) // if array is empty
            {
                result[0] = -1;
            }
            else
            {
                int flag;
                for(int i = 0; i < n; i++)
                {
                 //   Console.WriteLine("it's the arr[i]" + arr[i]);
                    flag = 0;
                    for(int j = i +1; j <n; j++)
                    {
                        top = arr[i];
                        if (arr[j] > top)
                        {
                            result[i] = arr[j];
                            flag = 1;
                            break;
                        }
                    }
                    //top = arr[i];
                    if (flag == 0) { result[i] = -1;}
                }
                //for(int i = 1; i < n; i++) {
                //    if (arr[i] > top)
                //    {
                //        result[i] = arr[i];
                //        top = arr[i];
                //    }
                //}
            }
            return result;
        }
        #endregion
    }

    public class ArrStack
    {

        // int[] arr;
        long top = -1;
        int size = 0;
        public ArrStack(int n, long[] arr)
        {
            top = arr[0];
            size = n;
        }
        public bool IsEmpty()
        {
            return size == 0; ;
        }
        
    
}
}
