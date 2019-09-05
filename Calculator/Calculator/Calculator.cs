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
        public double add(double a, double b)
        {
            return a + b;
        }

        public double subtract(double a, double b)
        {
            return a - b;
        }

        public double multiple(double a, double b)
        {
            return a * b; 
        }

        public double divide(double a, double b)
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

        public double power(double a, double b)
        {
            return Math.Pow(a, b);
        }
    }
}
