// Program.cs
using System;

class Program
{
    static void Main()
    {
        // Step 2: Instantiate the MathOperations class.
        MathOperations mathObj = new MathOperations();

        // Step 3: Call the method in the class, passing in two numbers.
        mathObj.PerformMathOperation(3, 7);

        // Step 4: Call the method in the class, specifying the parameters by name.
        mathObj.PerformMathOperation(firstNumber: 5, secondNumber: 10);
    }
}
