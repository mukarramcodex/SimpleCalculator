using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    internal class SimpleCalculatorProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Simple Calculator ===");

            Console.Write("Enter First Number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter an operator (+, -, *, /): ");
            string op = Console.ReadLine();

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result;

            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;

                case "-":
                    result = num1 - num2;
                    break;

                case "*":
                    result = num1 * num2;
                    break;

                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Cannot divide by zero.");
                        return;
                    }
                    result = num1 / num2;
                    break;

                default:
                    Console.WriteLine("Invalid Opreator!");
                    return;
            }
            Console.WriteLine($"Result: {result}");
        }
    }
}
