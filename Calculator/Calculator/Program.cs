using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t----Simple Calculator----");
            Console.WriteLine("Operations You Can Do Here( + , - , * , / , % )");
            Console.WriteLine(@"Type ""end"" For Exit ");


            while (true)
            {
                
                Console.Write("Enter Your First Number: ");
                double firstNumber = double.Parse(Console.ReadLine());

                Console.Write("Select Operation( + , - , * , / , % ): ");
                string operation = Console.ReadLine();

                Console.Write("Enter Your Second Number: ");
                double secondNumber = double.Parse(Console.ReadLine());

                double result = 0;
                if (operation == "+")
                {
                    result = firstNumber + secondNumber;
                }
                else if (operation == "-")
                {
                    result = firstNumber - secondNumber;
                }
                else if (operation == "*")
                {
                    result = firstNumber * secondNumber;
                }
                else if (operation == "/")
                {
                    result = firstNumber / secondNumber;
                }
                else if (operation == "%")
                {
                    result = firstNumber % secondNumber;
                }

                Console.WriteLine($"Result For {firstNumber}{operation}{secondNumber} is : {result}");
                Console.WriteLine(@"If if want to continue press ""Enter"" button,\n" +
                    @"If you want to exit type ""end""");
                if (Console.ReadLine() == "end")
                {
                    break;
                }
            }

        }
    }
}
