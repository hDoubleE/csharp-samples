using System;

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

            // Print data.
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
            Console.WriteLine(SequentialSearch(data, val));

        }

        public static int SequentialSearch(int[] arr, int targetValue)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == targetValue)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}