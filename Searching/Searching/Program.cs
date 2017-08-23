using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Searching
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[8]
            {
                16, 30, 24, 7, 62, 45, 5, 55
            };

            int[] sortedArr = new int[8]
            {
                5, 7, 16, 24, 30, 45, 55, 62
            };

            Console.Write("Please enter search value for sequential search: ");
            int searchValue = Convert.ToInt32(Console.ReadLine());
            int index = SequentialSearch(arr, searchValue);
            Console.WriteLine("Index of {0} value in array is : {1}",searchValue, index.ToString());

            Console.Write("Please enter search value for binary search: ");
            int searchValue2 = Convert.ToInt32(Console.ReadLine());
            int index2 = BinarySearch(sortedArr, searchValue2);
            Console.WriteLine("Index of {0} value in array is : {1}", searchValue2, index2.ToString());
        }

        private static int SequentialSearch(int[] arr, int searchNumber) {

            arr[arr.Length - 1] = searchNumber;

            int i;
            for (i = 0; arr[i] != searchNumber; i++) ;
            return (i < arr.Length - 1) ? i : -1;
        }

        private static int BinarySearch(int[] arr, int searchNumber) {

            int left = 0;
            int right = arr.Length - 1;

            int middle;

            while (left <= right) {

                middle = (left + right) / 2;
                switch(Compare(arr[middle], searchNumber)){
                
                    case -1: left = middle + 1; break;
                    case 0: return middle;
                    case 1: right = middle - 1; break;
                }
            }
            return -1;
        }

        private static int Compare(int x, int y) {

            return x < y ? -1 : (y < x ? 1 : 0);
        }

    }
}
