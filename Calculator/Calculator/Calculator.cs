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
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b; 
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new Exception();
            }
            else
            {
                return a / b;
            }
        }

        public double Power(double a, double b)
        {
            return Math.Pow(a, b);
        }

        // Overloaded functions
        public double Add(double addend)
        {
            return Accumulator + addend;
        }

        public double Subtract(double subtractor)
        {
            return Accumulator - subtractor;
        }

        public double Multiply(double multiplier)
        {
            return Accumulator * multiplier;
        }

        public double Divide(double divisor)
        {
            if (divisor == 0) throw new Exception();
            return Accumulator / divisor;
        }

        public double Power(double exponent)
        {
            return Math.Pow(Accumulator, exponent);
        }


    }


}
