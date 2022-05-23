using System;

namespace Insertion_Sort
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] Reversesorted = { 20, 18, 12, 8, 5, -2 };
            int[] Fewuniques = { 5, 12, 7, 5, 5, 7 };
            int[] Nearlysorted = { 2, 3, 5, 7, 13, 11 };
            int[] Sample = { 8, 4, 23, 42, 16, 15 };

            Console.WriteLine("Reversesorted");

            int[] arr1 = InsertionSort(Reversesorted);

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write("[ " + arr1[i] + " ]");
            }

            Console.WriteLine();
            Console.WriteLine("Fewuniques");

            int[] arr2 = InsertionSort(Fewuniques);

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write("[ " + arr2[i] + " ]");
            }

            Console.WriteLine();
            Console.WriteLine("Nearlysorted");

            int[] arr3 = InsertionSort(Nearlysorted);

            for (int i = 0; i < arr3.Length; i++)
            {
                Console.Write("[ " + arr3[i] + " ]");
            }

            Console.WriteLine();
            Console.WriteLine("Sample");

            int[] arr4 = InsertionSort(Sample);

            for (int i = 0; i < arr4.Length; i++)
            {
                Console.Write("[ " + arr4[i] + " ]");
            }




        }





        public static int[] InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int j = i - 1;
                int temp = arr[i];

                while (j >= 0 && temp < arr[j])
                {
                    arr[j + 1] = arr[j];
                    j -= 1;
                }
                arr[j + 1] = temp;
            }
            return arr;
        }
    }








}

