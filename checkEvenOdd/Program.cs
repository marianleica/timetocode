using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            string? numCheckInput = Console.ReadLine();
            int numCheck = Convert.ToInt32(numCheckInput);
            int checkResult = numCheck % 2;
            Console.WriteLine();
            
            if (checkResult == 0)
            {
                Console.WriteLine("The number " + numCheck + " is even!");
            }
            else
            {
                Console.WriteLine("The number " + numCheck + " is odd!");
            }
        }
    }