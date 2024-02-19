using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 =  0;
            int num2 =  0;
            string operation = "";

            Console.WriteLine("my first calculator in C#");
            Console.WriteLine("------------------------");


            // get the first number
            Console.Write("Enter the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            // get the second number
            Console.Write("Enter the second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            // get the operation
            Console.Write("Enter the operation (+, -, *, /): ");
            operation = Console.ReadLine();

            // Perform the operation and output the result
            switch (operation)
            {
                case "+":
                    Console.WriteLine($"Result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "-":
                    Console.WriteLine($"Result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "*":
                    Console.WriteLine($"Result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "/":
                    if (num2 !=  0)
                    {
                        Console.WriteLine($"Result: {num1} / {num2} = " + (num1 / num2));
                    }
                    else
                    {
                        Console.WriteLine("Error: Cannot divide by zero.");
                    }
                    break;
                default:
                    Console.WriteLine("Error: Invalid operation.");
                    break;
            }

            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}