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

        static void Main(string[] args)
        {
            Program obj = new Program();
			int val = obj.DivideTest(4, 4);
            Console.WriteLine("{0}", val);
            int[] arr = { 1, 2, 3 };
            int element = obj.GetMax(arr);
            Console.WriteLine("{0}", element);
            Console.ReadKey();
        }

       
    }
}
