using System;
using System.Text; //provides classes and functionalities for working with text, strings, and character encoding
using System.Threading.Tasks; //asyncronous programming

namespace CalculatorApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string value; //declare variable string named value
            do
            {
                int res; //result var instantiated

                Console.Write("Enter first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter symbol(/,+,-,*): ");
                string symbol = Console.ReadLine();

                //switch statements for the different choices for the "symbol" var
                switch (symbol)
                {
                    //each switch statement is a case
                    case "+":
                        res = num1 + num2;
                        Console.WriteLine("Addition: " + res);
                        break; //breaks out of switch statement

                    case "-":
                        res = num1 - num2;
                        Console.WriteLine("Subtraction: " + res);
                        break; //breaks out of switch statement

                    case "/":
                        res = num1 / num2;
                        Console.WriteLine("Division: " + res);
                        break; //breaks out of switch statement

                    case "*":
                        res = num1 * num2;
                        Console.WriteLine("Multiplication: " + res);
                        break; //breaks out of switch statement

                    default:
                        Console.WriteLine("Wrong Input");
                        break; //breaks out of switch statement
                }
                Console.ReadLine();
                Console.Write("Do you want to continue? (y/n): ");
                value = Console.ReadLine();
            }
            while (value == "y" || value == "Y"); // == strict equals
        }
    }
}
