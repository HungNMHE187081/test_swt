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
    }

    static void MethodWithTooManyParameters(int a, int b, int c, int d, int e, int f, int g, int h, int i, int j)
    {
        // Do something
    }
}