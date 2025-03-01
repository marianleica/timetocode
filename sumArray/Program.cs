// function that calculates the sum of all elemnts in the array

using System;

namespace sumArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1, 2, 3, 4, 5};
            Console.WriteLine(sumArray(arr));
        }

        static int sumArray(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
    }
}