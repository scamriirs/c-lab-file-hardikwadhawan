using System;

class Program
{
    static void Main()
    {
        // Declare and initialize a one-dimensional array with 5 elements
        int[] arr = { 10, 20, 30, 40, 50 };

        // Display elements of the array
        Console.WriteLine("Elements of the one-dimensional array:");

        // Access and display array elements using a loop
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("Element at index " + i + ": " + arr[i]);
        }
    }
}
