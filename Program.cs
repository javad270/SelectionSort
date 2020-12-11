using System;

namespace SelectionSort
{

    class Sorting
    {
        public static int[] sorting()
        {
            Console.WriteLine("\n\"Unsorted Random Numbers\"");
            int[] unsortedArray = new int[10];
            Random r = new Random();
            for (int i = 0; i < unsortedArray.Length; i++)
            {
                unsortedArray[i] = r.Next(10, 20);
                Console.Write(unsortedArray[i] + "  ");
            }
           return SelectionSort(unsortedArray);
        }
        public static int[] SelectionSort(int[] unsortedArray)
        {
            int N = unsortedArray.Length;
            for (int i = 0; i < N - 1; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if (unsortedArray[i] > unsortedArray[j])
                    {
                        int num = unsortedArray[i];
                        unsortedArray[i] = unsortedArray[j];
                        unsortedArray[j] = num;
                    }
                }
            }
            return unsortedArray;
        }
        
    }
    class Program
    {
        public static void Main(string[] args)
        {
            int[] sortedArray = Sorting.sorting();
            Console.WriteLine("\n\" SELECTION SORTED NUMBERS\"");
            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.Write(sortedArray[i] + "  ");
            }
            Console.ReadKey();
        }
    }
}
