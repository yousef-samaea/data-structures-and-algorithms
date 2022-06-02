using System;

namespace Merge_Sort
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 8, 4, 23, 42, 16, 15 };
            int[] reverseSorted = { 20, 18, 12, 8, 5, -2 };
            int[] fewUniques = { 5, 12, 7, 5, 5, 7 };
            int[] nearlySorted = { 2, 3, 5, 7, 13, 11 };

            Console.WriteLine("befor sorting: [8, 4, 23, 42, 16, 15]");
            int[] arr = MergeSort(x);
            Console.Write("after sorting: ");
            Console.Write("[ ");
            Print(arr);
            Console.WriteLine("]");
            Console.WriteLine("************************************");

            Console.WriteLine("befor sorting: [20, 18, 12, 8, 5, -2]");
            int[] arr2 = MergeSort(reverseSorted);
            Console.Write("after sorting: ");
            Console.Write("[ ");
            Print(arr);
            Console.WriteLine("]");
            Console.WriteLine("************************************");

            Console.WriteLine("befor sorting: [5, 12, 7, 5, 5, 7]");
            int[] arr3 = MergeSort(fewUniques);
            Console.Write("after sorting: ");
            Console.Write("[ ");
            Print(arr);
            Console.WriteLine("]");
            Console.WriteLine("************************************");

            Console.WriteLine("befor sorting: [2, 3, 5, 7, 13, 11]");
            int[] arr4 = MergeSort(nearlySorted);
            Console.Write("after sorting: ");
            Console.Write("[ ");
            Print(arr);
            Console.Write("]");


        }


        public static void Print(int[] x)
        {
            int arr = x.Length;
            for (int i = 0; i < arr; i++)
                Console.Write(x[i] + " ");
        }


        public static int[] MergeSort(int[] arr)
        {
            int n = arr.Length;
            if (n > 1)
            {
                int mid = n / 2;
                int[] left = new int[mid];
                int[] right = new int[n - mid];

                for (int i = 0; i < n; i++)
                {
                    if (i < mid)
                    {
                        left[i] = arr[i];
                    }
                    else
                    {
                        right[i - mid] = arr[i];
                    }
                }
                MergeSort(left);
                MergeSort(right);
                Merge(left, right, arr);
            }return arr;
        }
        public static void Merge(int[] left, int[] right, int[] arr)
        {
            int i = 0;
            int j = 0;
            int k = 0;
            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    arr[k] = left[i];
                    i++;
                }
                else
                {
                    arr[k] = right[j];
                    j++;
                }
                k++;
            }
            if (i == left.Length)
            {
                while (j < right.Length)
                {
                    arr[k] = right[j];
                    j++;
                    k++;
                }
            }
            else
            {
                while (i < left.Length)
                {
                    arr[k] = left[i];
                    i++;
                    k++;
                }
            }
        }
    }
}
