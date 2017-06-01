using System;

namespace ConsoleApplication2
{
    class Program
    {
		
		//Divide 2 numbers
        internal int DivideTest(int n, int d)
        {
            if (d == 0)
                return -1;

            return (n / d);
        }
		
		//O(n) time and O(1) space complexity
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
		
		//O(log n) time and O(1) space complexity
		internal int BinarySearch(int[] arr, int target, bool iterRecur)
        {
            int low = 0, high = arr.Length - 1;
            if (iterRecur)
                res = BinarySearchRecur(arr, low, high, target);
            else
                res = BinarySearchIterative(arr, low, high, target);
            return res;
        }

		//Recursive BinarySearch
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
		
		//Iterative BinarySearch
        private int BinarySearchIterative(int[] arr, int low, int high, int target)
        {
            //Base case with 1 element
            if (arr.Length == 1)
                return -1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (arr[mid] == target)
                    return mid;
                if (arr[mid] < target)
                    low = mid + 1;
                else
                    high = mid - 1;
            }
            return -1;
        }
		
		//O(n) time and O(1) space complexity
        internal bool LinearSearch(int[] arr, int key)
        {
            if (arr.Length == 1 && arr[0] == key)
                return true;

            bool res = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == key)
                {
                    //If element found update the res and break;
                    res = true;
                    break;
                }
            }

            return res;
        }
		
		//O(n) time and O(1) space complexity
        internal int GetConsecutiveOnes(int[] arr1)
        {
            //Null check 
            if (arr1.Length == 0)
                return -1;

            //Base case
            if (arr1.Length == 1 && arr1[0] == 1)
                return 1;

            int maxCount = 0;
            int count = 1;
            int n = arr1.Length;

            for (int i = 0; i < n - 1; i++)
            {
                if (arr1[i] == 1 && arr1[i + 1] == 1)
                {
                    count = count + 1;
                }
                else if (arr1[i] == 0 && arr1[i + 1] == 1)
                {
                    count = 1;
                }
                else
                {
                    count = 0;
                }
                if (maxCount < count)
                    maxCount = count;
            }
            return maxCount;
        }

        //Check if the string is a palindrome in O(n) time complexity
        internal bool PalindromeCheck(string str)
        {
            int startInd = 0;
            int endInd = str.Length - 1;
            bool res = Palindrome(str, startInd, endInd);
            return res;
        }
        private bool Palindrome(string str, int startInd, int endInd)
        {
            //Null check 
            if (str.Length == 0)
                return true;

            int i = startInd;
            int j = endInd;

            while (i < j)
            {
                if (str[i] != str[j])
                    return false;

                i++;
                j--;
            }

            return true;
        }

		//Check if array contains 2 numbers that add upto a given sum 
        internal bool CheckTwoSum(int[] arr, int sum)
        {
            //Null check 
            if (arr.Length == 0)
                return false;

            if (arr.Length == 2 && (arr[0] + arr[1]) == sum)
                return true;

            Array.Sort(arr);
            int left = 0, right = arr.Length - 1;

            while (left < right)
            {
                if ((arr[left] + arr[right]) == sum)
                    return true;

                if (arr[left] + arr[right] < sum)
                    left++;
                else
                    right--;
            }
            return false;
        }
		
        static void Main(string[] args)
        {
            Program obj = new Program();
			
			//Divide 2 elements
			int val = obj.DivideTest(4, 4);
            Console.WriteLine("{0}", val);
            
			//Get max element in an array
			int[] arr = { 1, 2, 3 };
            int element = obj.GetMax(arr);
            Console.WriteLine("{0}", element);
			
			//Check for a given element in a sorted using Binary search 
			int[] arr = new int[] { 1, 2, 3, 4, 5 };
            int key1 = 1;
            bool iterRecur = false;
            int res = obj.BinarySearch(arr, key1, iterRecur);
            Console.WriteLine("Target element found at {0}", res);
			
			// Check for a given element in a sorted using Linear search
            bool res = obj.LinearSearch(arr, 2);
            Console.WriteLine("Target element found at {0}", res);
			
            //Get max count of 1's in an array
            int[] arr2 = { 1, 1, 0, 1, 1, 1 };
            int maxCount = obj.GetConsecutiveOnes(arr2);
            Console.WriteLine("{0}", maxCount);

            //Check if the string is a palindrome
            string str = "malayalam";
            bool result = obj.PalindromeCheck(str);
            Console.WriteLine("{0}", result);
			
			
			//Check if array contains 2 numbers that add upto a given sum 
            int[] arr3 = { 6, 5, 4, 3, 2, 1, 9, 8, 7 };
            int sum3 = 18;
            bool result1 = obj.CheckTwoSum(arr3, sum3);
            Console.WriteLine("{0}", result1);
            Console.ReadKey();
        }

       
    }
}
