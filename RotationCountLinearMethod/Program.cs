using System;
using System.Linq;

namespace RotationCountLinearMethod
{
    class Program
    {
        public int FindIndex(int[] arr)
        {
            //int index = 0;
            //int value = arr[0];

            //Find the Minimun using Linq method
            int minValue = arr.Min();

            //Find the index of the minimum using C# a method
            int index = Array.IndexOf(arr, minValue);

            //for (int i = 1; i< arr.Length; i++)
            //{
            //    if (value > arr[i])
            //    {
            //        value = arr[i];
            //        index = i;
            //    }
            //}

            return index;
        }


        static void Main(string[] args)
        {
            Program program = new Program();

            int[] arr = { 15, 18, 2, 3, 6, 12 };

            int index = program.FindIndex(arr);

            Console.WriteLine("The array is rotated " + index + " times.");
        }
    }
}
