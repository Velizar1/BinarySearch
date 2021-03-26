using System;
using System.Linq;

namespace BinarySearch
{
    class Program
    {

        //[]arr must be sorted
        public static int? Search(int[] arr, int item, int start, int end)
        {

            int midIndex = (start + end) / 2;
            if (arr[midIndex].Equals(item)) return midIndex;
            else if (end == start+1) return -1;

            if (arr[midIndex] > item)
            {
                return Search(arr, item, start, midIndex);
            }
            else
            {
                return Search(arr, item, midIndex, end);
            }

        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 11, 22, 33, 44, 55, 66, 77, 99, 100, 111 };
            Console.WriteLine(Program.Search(arr,101, 0, arr.Length));
        }
    }
}
