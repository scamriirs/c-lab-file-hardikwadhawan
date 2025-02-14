using System;

class Program
{
    static void Main()
    {
        // Initialize some sample strings
        string str1 = "Hello";
        string str2 = "World";
        string str3 = "hello";

        // Demonstrating the Compare() method
        Console.WriteLine("Demonstrating Compare() method:");
        int result1 = string.Compare(str1, str2);
        Console.WriteLine($"Compare(str1, str2): {result1}");  // Compares str1 and str2

        int result2 = string.Compare(str1, str3, true);  // Case-insensitive comparison
        Console.WriteLine($"Compare(str1, str3, true): {result2}");  // Compares str1 and str3 (ignoring case)

        // Demonstrating the CompareTo() method
        Console.WriteLine("\nDemonstrating CompareTo() method:");
        int result3 = str1.CompareTo(str2);
        Console.WriteLine($"str1.CompareTo(str2): {result3}");  // Compares str1 and str2

        int result4 = str2.CompareTo(str1);
        Console.WriteLine($"str2.CompareTo(str1): {result4}");  // Compares str2 and str1

        int result5 = str1.CompareTo(str3);
        Console.WriteLine($"str1.CompareTo(str3): {result5}");  // Compares str1 and str3

        // Demonstrating the Concat() method
        Console.WriteLine("\nDemonstrating Concat() method:");
        string result6 = string.Concat(str1, " ", str2);
        Console.WriteLine($"Concat(str1, str2): {result6}");  // Concatenates str1 and str2

        string result7 = string.Concat(str1, " ", str2, "!", " ", "C#");
        Console.WriteLine($"Concat(str1, str2, '!'): {result7}");  // Concatenates multiple strings
    }
}
