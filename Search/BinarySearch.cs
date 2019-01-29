using System;

// Only a couple chances to ever use a do-while loop, so I've included that version here.
// Binary Search is great, big oh of log n, but it has to be sorted data. 

namespace Sorting
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter some numbers, separated by spaces:");

            // Process input string into string array.
            string strInput = Console.ReadLine().Trim();
            string[] strArray = strInput.Split(' ');

            // Parse out string array into integer array.
            int[] data = new int[strArray.Length];

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = int.Parse(strArray[i]);
            }

            // Sort array
            Array.Sort(data);

            // Print sorted data.
            Console.Write("\nArray to search: ");
            foreach (var i in data)
            {
                Console.Write($"{i} ");
            }

            // Query number to search:
            Console.WriteLine("\nEnter number to find:");
            string input = Console.ReadLine().Trim();
            int val;
            int.TryParse(input, out val);

            // Print index value is found at or -1.
            Console.WriteLine($"Binary search result v1: {BinarySearch(data, val)}");
            Console.WriteLine($"Binary search result v2: {BinarySearchDo(data, val)}");

        }

        public static int BinarySearch(int[] arr, int targetValue)
        {
            int lower = 0;
            int upper = arr.Length - 1;
            int middle = (lower + upper) / 2;
            while (arr[middle] != targetValue && lower < upper)
            {
                if (targetValue < arr[middle])
                {
                    upper = middle - 1;
                }
                else
                {
                    lower = middle + 1;
                }
                middle = (lower + upper) / 2;
            }
            if (targetValue == arr[middle])
            {
                return middle;
            }
            return -1;
        }

        public static int BinarySearchDo(int[] arr, int val)
        {
            int min = 0;
            int max = arr.Length - 1;
            do
            {
                int mid = (min + max) / 2;
                if (val < arr[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
                if (val == arr[mid])
                {
                    return mid;
                }
            }
            while (min <= max);
            return -1;
        }
    }
}