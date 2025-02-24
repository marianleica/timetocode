/*
Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.

Each letter in magazine can only be used once in ransomNote.

Example 1:

Input: ransomNote = "a", magazine = "b"
Output: false
Example 2:

Input: ransomNote = "aa", magazine = "ab"
Output: false
Example 3:

Input: ransomNote = "aa", magazine = "aab"
Output: true

Constraints:

1 <= ransomNote.length, magazine.length <= 105
ransomNote and magazine consist of lowercase English letters.
*/


using System;

public class Program
{
    // Method to check if ransomNote can be constructed from magazine
    public static bool CanConstruct(string ransomNote, string magazine)
    {
        // Array to count the frequency of each character in magazine
        int[] charCount = new int[26];

        // Increment the count for each character in magazine
        foreach (char c in magazine)
        {
            charCount[c - 'a']++;
            Console.WriteLine("My vector charCount for magazine is : " + charCount[c-'a'] + " for character " + c);
        }

        // Decrement the count for each character in ransomNote
        foreach (char c in ransomNote)
        {
            // If the character is not available, return false
            if (charCount[c - 'a'] == 0)
            
            {
                return false;
            }

            charCount[c - 'a']--;
            Console.WriteLine("My vector charCount for ransomNote is : " + charCount[c-'a'] + " for char c " + c);
        }

        // If all characters are available, return true
        return true;
    }

    public static void Main(string[] args)
    {
        // Example input
        string ransomNote = "g6tvtrvygby";
        string magazine = "tfvtfvrdefcrf";

        // Call the CanConstruct method and print the result
        bool result = CanConstruct(ransomNote, magazine);
        Console.WriteLine("Output: " + result);
    }
}

// Time complexity: O(n)
// Space complexity: O(1)




