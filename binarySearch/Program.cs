using System;

class Program
{

    static int BinarySearch(int[] arr, int target)
    {
        int low = 0;
        int high = arr.Length - 1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2; // To prevent overflow

            // Check if the target is present at mid
            if (arr[mid] == target)
                return mid; // Target found, return index

            // if target is smaller than mid, it can only be in the left subarray
            if (arr[mid] > target){
                high = mid - 1 // search the left half
            // if target is larger than mid, it can only be in the right subarray
            }
            else
            {
                low = mid + 1; // search the right half
            }
        }

        // otherwise, element not found
        return -1;
    }

    static void Main()
    {
        int[] arr = { 1, 2, 4, 6, 23, 12, 13, 125, 35, 42, 21};
        int target = 7;

        int result = BinarySearch(arr, target);

        if (result != -1)
            Console. WriteLine($"Element was found at index {result}");
        else
            Console.WriteLine("Element not found");
    }





}