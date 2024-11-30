using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Calculator!");
        Console.WriteLine("Select an operation:");
        Console.WriteLine("1: Add");
        Console.WriteLine("2: Subtract");
        Console.WriteLine("3: Multiply");
        Console.WriteLine("4: Divide");

        int choice = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the first number:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = 0;

        switch (choice)
        {
            case 1:
                result = num1 + num2;
                Console.WriteLine($"Result: {num1} + {num2} = {result}");
                break;
            case 2:
                result = num1 - num2;
                Console.WriteLine($"Result: {num1} - {num2} = {result}");
                break;
            case 3:
                result = num1 * num2;
                Console.WriteLine($"Result: {num1} * {num2} = {result}");
                break;
            case 4:
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine($"Result: {num1} / {num2} = {result}");
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                break;
            default:
                Console.WriteLine("Invalid operation. Please select a valid option.");
                break;
        }
    }
}
