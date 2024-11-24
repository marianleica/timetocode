using System;

    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 1, 2, 4, 5, 7};

            // To add a new value, create a new array with the extra element in size
            // The block here is that the size of the defined array has to be changed to a currnt +1
            int[] newArr = new int[arr.Length + 1];

            // Copy the old array into the new array
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }

            // Then add the new value
            newArr[newArr.Length - 1] = 9;

            // Printing it
            foreach (var item in newArr)
            {
                Console.WriteLine(item);
            }

        }

    }
