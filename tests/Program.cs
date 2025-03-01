// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Choose number:");
        int input = 7;
        int sum = 0;
        int i;
        
        int[] array = new int[input + 1];

        for (i = 0; i < input; i++)
        {
            array[i] = i + 1;
        }
        
        for (i = 0; i < array.Length; i++)
        {
            sum = sum + array[i];
        }
        Console.WriteLine(sum);
    }
}