using System;

class Program
{
    // Recursive method to calculate the factorial of a number
    static int Factorial(int n)
    {
        // Base case: Factorial of 0 or 1 is 1
        if (n <= 1)
        {
            return 1;
        }
        else
        {
            // Recursive case: n * Factorial of (n - 1)
            return n * Factorial(n - 1);
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter a number to calculate its factorial:");
        int number = int.Parse(Console.ReadLine());

        // Call the recursive method and display the result
        int result = Factorial(number);
        Console.WriteLine($"Factorial of {number} is: {result}");
    }
}
