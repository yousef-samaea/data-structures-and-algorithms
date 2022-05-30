using System;

namespace Quick_Sort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("QuickSort the next numbers:");
            Console.WriteLine("[8, 4, 23, 42, 16, 15]");
            int[] x = { 8, 4, 23, 42, 16, 15 };
            int[] arr = QuickSort(x, 0, x.Length - 1);
            //Console.Write("[");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] +" ");
            //}
            //Console.Write("]");
            /*Program.*/
            Console.Write("[");
            Print(arr);
            Console.Write("]");

        }
        public static void Print(int[] x)
        {
            int arr = x.Length;
            for (int i = 0; i < arr; i++)
                Console.Write(x[i] + " ");
        }
        public static int[] QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int position = Partition(arr, left, right);

                QuickSort(arr, left, position - 1);
                QuickSort(arr, position + 1, right);
            }
            return arr;
        }
        public static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int low = left - 1;

            for (int i = left; i < right; i++)
            {
                if (arr[i] <= pivot)
                {
                    low++;
                    Swap(arr, i, low);
                }
            }

            Swap(arr, right, low + 1);

            return low + 1;
        }

        public static void Swap(int[] arr, int i, int low)
        {
            int temp = arr[i];
            arr[i] = arr[low];
            arr[low] = temp;
        }

        

    }
}
