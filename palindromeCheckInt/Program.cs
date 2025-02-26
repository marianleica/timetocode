/*
Given an integer x, return true if x is a palindrome, and false otherwise.

Example 1:

Input: x = 121
Output: true
Explanation: 121 reads as 121 from left to right and from right to left.

Example 2:

Input: x = -121
Output: false
Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.

Example 3:

Input: x = 10
Output: false
Explanation: Reads 01 from right to left. Therefore it is not a palindrome.
 
Constraints:

-231 <= x <= 231 - 1
 
Follow up: Could you solve it without converting the integer to a string?
*/

using System;

namespace palindromeCheckInt
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test the IsPalindrome method with an example input
            Console.WriteLine(IsPalindrome(121)); // Output: true
        }

        // Method to check if an integer is a palindrome
        static bool IsPalindrome(int x)
        {
            // If the number is negative, it cannot be a palindrome
            if (x < 0)
                return false;

            // Store the original number in a temporary variable
            int temp = x;
            // Variable to store the reversed number
            long reversed = 0;

            // Loop to reverse the digits of the number
            while (temp != 0)
            {
                // Add the last digit of temp to reversed
                reversed = reversed * 10 + temp % 10;
                //Console.WriteLine(reversed);
                //Console.WriteLine(temp % 10);
                // Remove the last digit from temp
                temp /= 10;
                //Console.WriteLine(temp);
                //Console.WriteLine();
            }

            // Check if the reversed number is equal to the original number
            return reversed == x;
        }
    }
}