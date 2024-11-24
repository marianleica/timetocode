using System;

class Program
{
    static int BinarySearchRecursive(int[] arr, int target, int low, int high)
    {
        // Base case: If the range is invalid
        if (low > high)
            return -1;

        int mid = low + (high - low) / 2; // To prevent overflow

        // Check if the target is at mid
        if (arr[mid] == target)
            return mid;

        // If the target is smaller, search in the left subarray
        if (arr[mid] > target)
            return BinarySearchRecursive(arr, target, low, mid - 1);

        // If the target is larger, search in the right subarray
        return BinarySearchRecursive(arr, target, mid + 1, high);
    }

    static void Main()
    {
        int[] arr = { 1, 3, 5, 7, 9, 11, 13, 15 };
        int target = 7;

        int result = BinarySearchRecursive(arr, target, 0, arr.Length - 1);

        if (result != -1)
            Console.WriteLine($"Element found at index {result}");
        else
            Console.WriteLine("Element not found");
    }
}
