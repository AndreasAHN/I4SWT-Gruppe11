using System;


namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to calculator,");

            var uut = new Calculator();
            bool end = true;

            while (end)
            {
                Console.WriteLine("write the first number...");
                int numberA = Int32.Parse(Console.ReadLine());
                Console.WriteLine("You wrote: {0}, type + or - or * or / or exp or clear or end", numberA);
                string chosenFunc = Console.ReadLine();
                Console.WriteLine("You chose: {0}, write the second number", chosenFunc);
                int numberB = Int32.Parse(Console.ReadLine());
                Console.WriteLine("You wrote: {0}, calculating...", numberB);

                switch (chosenFunc)
                {
                    case "+":
                        uut.Add(numberA, numberB);
                        break;
                    case "-":
                        uut.Subtract(numberA, numberB);
                        break;
                    case "*":
                        uut.Multiply(numberA, numberB);
                        break;
                    case "/":
                        uut.Divide(numberA, numberB);
                        break;
                    case "exp":
                        uut.Power(numberA, numberB);
                        break;
                    case "clear":
                        uut.Clear();
                        break;
                    case "end":
                        end = false;
                        break;
                    default:
                        Console.WriteLine("You wrote something wrong");
                        break;
                }

                Console.WriteLine("Answer: {0}", uut.Accumulator);
            }

            Console.WriteLine("Ending calculator");
        }
    }
}
