/*

Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.

 

Example 1:

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
Example 2:

Input: nums = [3,2,4], target = 6
Output: [1,2]
Example 3:

Input: nums = [3,3], target = 6
Output: [0,1]
 

Constraints:

2 <= nums.length <= 104
-109 <= nums[i] <= 109
-109 <= target <= 109
Only one valid answer exists.
 

Follow-up: Can you come up with an algorithm that is less than O(n2) time complexity?


*/

using System;

namespace twoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test the TwoSum method with an example input
            int[] result = TwoSum(new int[] { 2, 7, 11, 15 }, 9);
            Console.WriteLine($"[{result[0]}, {result[1]}]"); // Output: [0, 1]
        }

        // Method to find the indices of two numbers that add up to the target
        static int[] TwoSum(int[] nums, int target)
        {
            // Create a dictionary to store the indices of the numbers
            Dictionary<int, int> dict = new Dictionary<int, int>();

            // Loop through the array
            for (int i = 0; i < nums.Length; i++)
            {
                // Calculate the difference between the target and the current number
                int diff = target - nums[i];

                // If the difference is already in the dictionary, return the indices
                if (dict.ContainsKey(diff))
                    return new int[] { dict[diff], i };

                // If the difference is not in the dictionary, add the current number to the dictionary
                if (!dict.ContainsKey(nums[i]))
                    dict.Add(nums[i], i);
            }

            // Return an empty array if no solution is found
            return new int[0];
        }
    }
}
