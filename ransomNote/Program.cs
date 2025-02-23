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
    public static bool CanConstruct(string ransomNote, string magazine)
    {
        int[] charCount = new int[26];

        foreach (char c in magazine)
        {
            charCount[c - 'a']++;
        }

        foreach (char c in ransomNote)
        {
            if (charCount[c - 'a'] == 0)
            {
                return false;
            }
            charCount[c - 'a']--;
        }

        return true;
    }

    public static void Main(string[] args)
    {
        // Main method implementation
        string ransomNote = "aa";
        string magazine = "aab";

        bool result = CanConstruct(ransomNote, magazine);
        Console.WriteLine("Output: " + result);
    }
}

// Time complexity: O(n)
// Space complexity: O(1)