using System;

class Program
{
    static bool IsPalindrome(string input)
    {
        for (int i = 0, j = input.Length - 1; i < j; i++, j--)
            if (Char.ToLower(input[i]) != Char.ToLower(input[j]))
                return false;
        return true;
    }

    static void Main()
    {
        string testWord = "Madam";
        Console.WriteLine($"'{testWord}' is {(IsPalindrome(testWord) ? "a palindrome" : "not a palindrome")}.");        
    }
}
