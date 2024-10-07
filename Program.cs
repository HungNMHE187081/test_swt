// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // Example of a potential issue: Unused variable
        int unusedVariable = 42;

        // Example of a potential issue: Hardcoded password
        string password = "12345";

        // Example of a potential issue: Empty catch block
        try
        {
            int result = 10 / int.Parse("0");
        }
        catch (Exception)
        {
            // Do nothing
        }

        // Example of a potential issue: Method with too many parameters
        MethodWithTooManyParameters(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

        // Example of a potential issue: Null reference exception
        string nullString = null;
        Console.WriteLine(nullString.Length);

        // Example of a potential issue: Unused method
        UnusedMethod();

        // Example of a potential issue: Infinite loop
        while (true)
        {
            // Do nothing
        }

        // Example of a potential issue: Array index out of bounds
        int[] array = new int[5];
        Console.WriteLine(array[10]);

        // Example of a potential issue: Division by zero
        int zero = 0;
        int divisionResult = 10 / zero;

        // Example of a potential issue: Unreachable code
        return;
        Console.WriteLine("This code is unreachable");

        // Example of a potential issue: String comparison without StringComparison
        string str1 = "test";
        string str2 = "TEST";
        if (str1 == str2)
        {
            Console.WriteLine("Strings are equal");
        }
    }

    static void MethodWithTooManyParameters(int a, int b, int c, int d, int e, int f, int g, int h, int i, int j)
    {
        // Do something
    }

    // Example of a potential issue: Unused method
    static void UnusedMethod()
    {
        // Do nothing
    }
}