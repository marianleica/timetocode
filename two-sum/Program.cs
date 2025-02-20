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

/*
Copilot check for hints:

To solve the "Two Sum" problem in C#, you can use a dictionary to achieve a time complexity of O(n). Here is a step-by-step guide to help you get started:

Create a Dictionary: Use a dictionary to store the numbers and their indices as you iterate through the array.
Iterate through the Array: For each number, calculate the complement (i.e., target - current number).
Check for Complement: If the complement exists in the dictionary, you have found the two indices that add up to the target.
Return the Indices: Return the indices of the current number and its complement.
*/

using System;
using System.Collections.Generic;

public class Program
{

    public static int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i, j };
                }
            }
        }
        return new int[] { -1, -1 }; // no solution scenario
    }

    public static int[] TwoSumAlt(int[] nums, int target)
    {
        Dictionary<int, int> numDict = new Dictionary<int, int>();
        
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (numDict.ContainsKey(complement))
            {
                return new int[] { numDict[complement], i };
            }
            numDict[nums[i]] = i;
        }
        return new int[] { -1, -1 }; // no solution scenario
    }

    public static void Main(string[] args)
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;

        int[] result = TwoSum(nums, target);
        Console.WriteLine($"Output: [{result[0]}, {result[1]}]");

        result = TwoSumAlt(nums, target);
        Console.WriteLine($"Output: [{result[0]}, {result[1]}]");
    }
}

