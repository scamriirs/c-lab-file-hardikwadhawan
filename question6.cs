Q.6

using System;

class Program
{
    static void Main()
    {
        // Declare an array to hold 10 elements
        int[] arr = new int[10];

        // Input 10 elements from the user
        Console.WriteLine("Enter 10 elements:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Element {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        // Sort the array in increasing order
        Array.Sort(arr);

        // Display the sorted array
        Console.WriteLine("\nArray elements in increasing order:");
        foreach (int element in arr)
        {
            Console.WriteLine(element);
        }
    }
}
