using System;

class Program
{
    // Method demonstrating Pass by Value
    static void PassByValue(int num)
    {
        num = 20;  // Modifying the parameter
        Console.WriteLine("Inside PassByValue method: " + num);
    }

    // Method demonstrating Pass by Reference
    static void PassByReference(ref int num)
    {
        num = 30;  // Modifying the original variable
        Console.WriteLine("Inside PassByReference method: " + num);
    }

    static void Main()
    {
        // Demonstrating Pass by Value
        int x = 10;
        Console.WriteLine("Before PassByValue method: " + x);
        PassByValue(x);  // Pass by value
        Console.WriteLine("After PassByValue method: " + x);  // x remains unchanged

        // Demonstrating Pass by Reference
        int y = 10;
        Console.WriteLine("\nBefore PassByReference method: " + y);
        PassByReference(ref y);  // Pass by reference
        Console.WriteLine("After PassByReference method: " + y);  // y is changed
    }
}
