using System;

class Program
{
    static int LinearSearch(int[] arr, int target)
    {
        // Iterate through the array
        for (int i = 0; i < arr.Length; i++)
        {
            // if the element matches the target, return the index
            if( arr[i] == target)
            {
                return i; // return the index where the target
            }
        }

        // Otherwise
        return -1;
    }

    static void Main()
    {
        // The array
        int[] numbers = { 3, 5 , 6, 7, 2, 4, 23, 53, 54, 55, 67};

        // The number we look for
        int target = 54;

        // Calling the linear search method
        int index = LinearSearch(numbers, target);

        // Showing the result
        if (index != -1)
        {
            Console.WriteLine($"Target {target} found at index {index}.");
        }
        else
        {
            Console.WriteLine($"Target {target} was not found.");
        }

    }
}