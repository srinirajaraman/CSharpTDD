using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        internal int DivideTest(int n, int d)
        {
            if (d == 0)
                return -1;

            return (n / d);
        }

        internal int GetMax(int[] arr)
        {
            if (arr.Length == 0)
                return arr[0];

            int maxElement = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (maxElement < arr[i])
                    maxElement = arr[i];
            }

            return maxElement;
        }
		internal int BinarySearch(int[] arr, int target)
        {
            int low = 0, high = arr.Length - 1;
            int res = BinarySearchUtil(arr, low, high, target);
            return res;
        }

        private int BinarySearchUtil(int[] arr, int low, int high, int target)
        {
            //Base case 
            if (high < low)
                return -1;

            int mid = (low + high) / 2;

            if (arr[mid] == target)
                return mid;

            if (arr[mid] < target)
                return BinarySearchUtil(arr, mid + 1, high, target);
            else
                return BinarySearchUtil(arr, low, mid - 1, target);
        }

        static void Main(string[] args)
        {
            Program obj = new Program();
			int val = obj.DivideTest(4, 4);
            Console.WriteLine("{0}", val);
            int[] arr = { 1, 2, 3 };
            int element = obj.GetMax(arr);
            Console.WriteLine("{0}", element);
			int[] arr = new int[] { 1, 2, 3, 4, 5 };
            int key1 = 1;
            int res = obj.BinarySearch(arr, key1);
            Console.WriteLine("Target element found at {0}", res);
            Console.ReadKey();
        }

       
    }
}
