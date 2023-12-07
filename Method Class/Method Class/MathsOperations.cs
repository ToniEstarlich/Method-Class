// MathOperations.cs
using System;

public class MathOperations
{
    // This method takes two integers as parameters,
    // performs a math operation on the first integer,
    // and displays the second integer to the screen.
    public void PerformMathOperation(int firstNumber, int secondNumber)
    {
        // Perform a simple math operation (for example, multiplication) on the first number.
        int result = firstNumber * 2;

        // Display the second number to the console.
        Console.WriteLine($"Result: {result}, Second Number: {secondNumber}");
    }
}