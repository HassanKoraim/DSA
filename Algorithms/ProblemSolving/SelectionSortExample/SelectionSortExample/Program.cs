using System.Drawing;

namespace SelectionSortExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size");
            int size = Convert.ToInt32(Console.ReadLine());
            List<int> inputs = new List<int>();
            for (int i = 0; i < size; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                inputs.Add(num);
            }
            List<int> inputs_sorted = selection_sort(inputs, size);
            // print the list
            foreach (int num in inputs_sorted)
            {
                Console.WriteLine(num);
            }
        }

        public static List<int> selection_sort(List<int> inputs, int size)
        {
            for (int i = 0; i < size - 1; i++)
            {
                int min_pos = i;
                for (int j = i +1; j < size; j++)
                {
                    if (inputs[j] < inputs[min_pos])
                    {
                       min_pos = j;
                    }
                }
                if (min_pos != i)
                {
                    int temp = inputs[i];
                    inputs[i] = inputs[min_pos];
                    inputs[min_pos] = temp;
                }
            }
            return inputs;
        }
    }
}
