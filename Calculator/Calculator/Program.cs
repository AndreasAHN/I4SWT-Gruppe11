using System;


namespace Calculator
{
    class Program //Dav dav 
    {
        Accumulator Output = new Accumulator();

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
                    Output.CalculatorOutput = uut.add(numberA, numberB);
                    break;
                case "-":
                    Output.CalculatorOutput = uut.subtract(numberA, numberB);
                    break;
                case "*":
                    Output.CalculatorOutput = uut.multiple(numberA, numberB);
                    break;
                case "/":
                    Output.CalculatorOutput = uut.divide(numberA, numberB);
                    break;
                case "exp":
                    Output.CalculatorOutput = uut.power(numberA, numberB);
                    break;
                default:
                    Console.WriteLine("You wrote something wrong");
                    break;
            }

            Console.WriteLine("Answer: {0}", Output.CalculatorOutput);
        }

        public void clear()
        {
            Output.CalculatorOutput = 0;
        }
    }

    class Accumulator
    {
        public double accumulator;

        public Accumulator()
        {
            accumulator = 0;
        }

        public override double CalculatorOutput
        {
            get
            {
                return accumulator;
            }
            set
            {
                accumulator = value;
            }
        }
    }
}
