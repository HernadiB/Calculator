using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            bool exit = false;

            Console.WriteLine("Welcome to Calculator App!");

            while (!exit)
            {
                try
                {
                    Console.Write("Enter operation (add, subtract, multiply, divide, exponentiate, sqrt) or 'exit' to quit: ");
                    string operation = Console.ReadLine().ToLower();

                    if (operation == "exit")
                    {
                        exit = true;
                        continue;
                    }

                    Console.Write("Enter first number: ");
                    double number1 = double.Parse(Console.ReadLine());

                    if (operation != "sqrt")
                    {
                        Console.Write("Enter second number: ");
                        double number2 = double.Parse(Console.ReadLine());

                        switch (operation)
                        {
                            case "add":
                                Console.WriteLine($"Result: {calculator.Add(number1, number2)}");
                                break;
                            case "subtract":
                                Console.WriteLine($"Result: {calculator.Subtract(number1, number2)}");
                                break;
                            case "multiply":
                                Console.WriteLine($"Result: {calculator.Multiply(number1, number2)}");
                                break;
                            case "divide":
                                Console.WriteLine($"Result: {calculator.Divide(number1, number2)}");
                                break;
                            case "exponentiate":
                                Console.WriteLine($"Result: {calculator.Exponentiate(number1, number2)}");
                                break;
                            default:
                                Console.WriteLine("Invalid operation. Please try again.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Result: {calculator.SquareRoot(number1)}");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception)
                {
                    Console.WriteLine("An error occurred. Please try again.");
                }

                Console.WriteLine();
            }

            Console.WriteLine("Thank you for using Calculator App!");
        }
    }
}
