using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Calculator;

namespace Calculator.Test.Unit
{
    [TestFixture]
    public class CalculatorTest
    {
        [TestCase(5, 7, 12)]
        [TestCase(10, 7, 17)]
        [TestCase(5, -6, -1)]
        public void Add_Return(double a, double b, double result)
        {
            var uut = new Calculator();

            Assert.That(uut.Add(a, b), Is.EqualTo(result));
        }

        [TestCase(5, -7, 12)]
        [TestCase(5, 7, -2)]
        [TestCase(5, 3, 2)]
        [TestCase(55, 7, 48)]
        public void Subtract_Return(double a, double b, double result)
        {
            var uut = new Calculator();

            Assert.That(uut.Subtract(a, b), Is.EqualTo(result));
        }

        [TestCase(12, 55, 660)]
        [TestCase(2, -6, -12)]
        [TestCase(2, 6, 12)]
        [TestCase(5, 6, 30)]
        public void multiple_Return(double a, double b, double result)
        {
            var uut = new Calculator();

            Assert.That(uut.Multiply(a, b), Is.EqualTo(result));
        }

        [TestCase(12, 3, 4)]
        [TestCase(12, -3, -4)]
        [TestCase(24, 2, 12)]
        public void divide_Return(double a, double b, double result)
        {
            var uut = new Calculator();

            Assert.That(uut.Divide(a, b), Is.EqualTo(result));
        }

        [Test]
        public void divide_ByZero()
        {
            var uut = new Calculator();

            Assert.That(() => uut.Divide( 5, 0), Throws.Exception);
        }

        [TestCase(20, 2, 400)]
        [TestCase(20, -2, 0.0025)]
        [TestCase(20, 3, 8000)]
        public void power_Return(double a, double b, double result)
        {
            var uut = new Calculator();

            Assert.That(uut.Power(20, 2), Is.EqualTo(400));
        }

        [TestCase(5, 5)]
        [TestCase(10, 10)]
        public void Accumulator_Add(double a, double result)
        {
            var uut = new Calculator();

            Assert.That(uut.Add(a), Is.EqualTo(result));
        }

        [TestCase(5, -5)]
        [TestCase(10, -10)]
        public void Accumulator_Subtract(double a, double result)
        {
            var uut = new Calculator();

            Assert.That(uut.Subtract(a), Is.EqualTo(result));
        }

        [TestCase(2, 4)]
        [TestCase(5, 10)]
        [TestCase(-5, -10)]
        public void Accumulator_Multiply(double a, double result)
        {
            var uut = new Calculator();

            uut.Add(2);

            Assert.That(uut.Multiply(a), Is.EqualTo(result));
        }

        [TestCase(2, 10)]
        [TestCase(-2, -10)]
        [TestCase(4, 5)]
        public void Accumulator_Divide(double a, double result)
        {
            var uut = new Calculator();

            uut.Add(20);

            Assert.That(uut.Divide(a), Is.EqualTo(result));
        }

        [TestCase(2, 4)]
        [TestCase(-2, 0.25)]
        [TestCase(5, 32)]
        public void Accumulator_Power(double a, double result)
        {
            var uut = new Calculator();

            uut.Add(2);

            Assert.That(uut.Power(a), Is.EqualTo(result));
        }

        [Test]
        public void Accumulator_Clear()
        {
            var uut = new Calculator();

            uut.Add(2);
            uut.Add(2);
            uut.Add(2);

            Assert.That(uut.Accumulator, Is.EqualTo(6));
            uut.Clear();
            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }

        [Test]
        public void Accumulator_Get()
        {
            var uut = new Calculator();

            uut.Add(2);
            Assert.That(uut.Accumulator, Is.EqualTo(2));
            uut.Add(2);
            Assert.That(uut.Accumulator, Is.EqualTo(4));
        }
    }
}
