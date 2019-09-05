using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public double Accumulator { get; private set; } = 0;

        public double Add(double a, double b)
        {
            Accumulator += (a + b);
            return Accumulator;
        }

        public double Subtract(double a, double b)
        {
            Accumulator += (a - b);
            return Accumulator;
        }

        public double Multiply(double a, double b)
        {
            Accumulator += (a * b);
            return Accumulator; 
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new Exception();
            }
            else
            {
                Accumulator += (a / b);
                return Accumulator;
            }
        }

        public double Power(double a, double b)
        {
            Accumulator += Math.Pow(a, b);
            return Accumulator;
        }

        public void Clear()
        {
            Accumulator = 0;
        }

        // Overloaded functions
        public double Add(double addend)
        {
            Accumulator += addend;
            return Accumulator;
        }

        public double Subtract(double subtractor)
        {
            Accumulator -= subtractor;
            return Accumulator;
        }

        public double Multiply(double multiplier)
        {
            Accumulator *= multiplier;
            return Accumulator;
        }

        public double Divide(double divisor)
        {
            if (divisor == 0) throw new Exception();
            Accumulator /= divisor;
            return Accumulator;
        }

        public double Power(double exponent)
        {
            Accumulator += Math.Pow(Accumulator, exponent);
            return Accumulator;
        }


    }


}
