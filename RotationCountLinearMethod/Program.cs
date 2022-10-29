using System;

namespace RotationCountLinearMethod
{
    class Program
    {
        public int FindIndex(int[] arr)
        {
            int index = 0;
            int value = arr[0];

            for (int i = 1; i< arr.Length; i++)
            {
                if (value > arr[i])
                {
                    value = arr[i];
                    index = i;
                }
            }

            return index;
        }


        static void Main(string[] args)
        {
            Program program = new Program();

            int[] arr = { 7, 9, 11, 12, 5 };

            int index = program.FindIndex(arr);

            Console.WriteLine("The array is rotated " + index + " times.");
        }
    }
}
