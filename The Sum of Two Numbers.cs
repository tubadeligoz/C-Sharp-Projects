using System;  // Importing the System library for console operations

class Program
{
    static void Main(string[] args)
    {
        // 1. Step: Asking the user for the first number
        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());  // Reading user input and converting it to a number

        // 2. Step: Asking the user for the second number
        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());  // Reading user input and converting it to a number

        // 3. Step: Adding the two numbers
        double sum = num1 + num2;  // Adding the numbers

        // 4. Step: Displaying the result
        Console.WriteLine($"The sum of {num1} and {num2} is: {sum}");  // Printing the result to the console
    }
}
