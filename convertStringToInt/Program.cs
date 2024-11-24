using System;

    class Program
    {
        static void Main(string[] args)
        {
            string str = "12321";
            int rez = 0;

            // We first iterate each character in the string
            foreach (char ch in str)
            {
                // checking if the char is a digit between 0 and 9
                if (ch >= '0' && ch <= '9')
                {
                    // convert the character to its digit
                    rez = rez * 10 + (ch - '0');
                }
                else
                {
                    // Handle the character not being valid
                    Console.WriteLine("Invalid character.");
                    return;
                }
            }
        
        // Checking if it worked
        Console.WriteLine(rez + 1 - 1);

        }

    }
