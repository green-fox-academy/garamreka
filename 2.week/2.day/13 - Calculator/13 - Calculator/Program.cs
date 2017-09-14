using System;

namespace _13___Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a simple calculator application which reads the parameters from the prompt
            // and prints the result to the prompt.
            // It should support the following operations:
            // +, -, *, /, % and it should support two operands.
            // The format of the expressions must be: {operation} {operand} {operand}.
            // Examples: "+ 3 3" (the result will be 6) or "* 4 4" (the result will be 16)

            // You can use the Scanner class
            // It should work like this:

            // Start the program
            // It prints: "Please type in the expression:"
            // Waits for the user input
            // Print the result to the prompt
            // Exit

            Console.WriteLine("Please type in the expression ({operation} {operand} {operand}): ");
            string[] userInput = Console.ReadLine().Split(' ');

            Calculator(userInput[0], int.Parse(userInput[1]), int.Parse(userInput[2]));
            Console.WriteLine();
            Console.ReadLine();
        }

        public static void Calculator(string operation, int operand1, int operand2)
        {
            int result = 0;

            if (operation == "-")
            {
                result = operand1 - operand2;
            }
            else if (operation == "+")
            {
                result = operand1 + operand2;
            }
            else if (operation == "*")
            {
                result = operand1 * operand2;
            }
            else if (operation == "/")
            {
                result = operand1 / operand2;
            }
            else
            {
                result = operand1 % operand2;
            }
            Console.WriteLine("The result is {0}", result);
        }
    }
}
