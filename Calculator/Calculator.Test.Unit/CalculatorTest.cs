﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Test.Unit
{
    [TestFixture]
    public class CalculatorTest
    {
        [Test]
        public void Add_Return()
        {
            var uut = new Calculator();

            Assert.That(uut.Add(12, 55), Is.EqualTo(72));
        }

        [Test]
        public void Subtract_Return()
        {
            var uut = new Calculator();

            Assert.That(uut.subtract(55, 12), Is.EqualTo(43));
        }

        [Test]
        public void multiple_Return()
        {
            var uut = new Calculator();

            Assert.That(uut.multiple(12, 55), Is.EqualTo(660));
        }
    }
}