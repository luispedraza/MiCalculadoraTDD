﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora;

namespace CalculadoraTest
{
    [TestFixture]
    public class CalcTest
    {
        [Test]
        public void TestSumaDeEnteros()
        {
            // Arrange
            int a = 4;
            int b = 3;
            int expected = 7;

            // Act
            int result = Calculadora.Calculadora.Suma(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
