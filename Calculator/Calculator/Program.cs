using System;


namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to calculator, write the first number...");
            int numberA = Int32.Parse(Console.ReadLine());
            Console.WriteLine("You wrote: {0}, type + or - or * or / or exp", numberA);
            string chosenFunc = Console.ReadLine();
            Console.WriteLine("You chose: {0}, write the second number", chosenFunc);
            int numberB = Int32.Parse(Console.ReadLine());
            Console.WriteLine("You wrote: {0}, calculating...", numberB);

            var uut = new Calculator();

            switch (chosenFunc)
            {
                case "+":
                    Console.WriteLine("Answer: {0}",(uut.add(numberA,numberB)));
                    break;
                case "-":
                    Console.WriteLine("Answer: {0}", (uut.subtract(numberA, numberB)));
                    break;
                case "*":
                    Console.WriteLine("Answer: {0}", (uut.multiple(numberA, numberB)));
                    break;
                case "/":
                    Console.WriteLine("Answer: {0}", (uut.divide(numberA, numberB)));
                    break;
                case "exp":
                    Console.WriteLine("Answer: {0}", (uut.power(numberA, numberB)));
                    break;
                default:
                    Console.WriteLine("You wrote something wrong");
                    break;
            }
        }
    }
}
