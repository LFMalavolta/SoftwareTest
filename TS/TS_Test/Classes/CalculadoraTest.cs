using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Classes;

namespace TS_Test.Classes
{
    internal class CalculadoraTest
    {
        Calculadora calculadora;

        [SetUp]
        public void Setup()
        {
            calculadora = new Calculadora();
        }

        [Test]
        public void TestSomar()
        {
            int resultadoSoma = calculadora.somar(5,5);
            int resultadoEsperado = 10;
            Assert.That(resultadoSoma, Is.EqualTo(resultadoEsperado));
        }

        [Test]
        public void TestSubtrair()
        {
            int resultadoSoma = calculadora.subtrair(5, 5);
            int resultadoEsperado = 0;
            Assert.That(resultadoSoma, Is.EqualTo(resultadoEsperado));
        }

        [Test]
        public void TestSubtrairComValorNegativo()
        {
            int resultadoSoma = calculadora.subtrair(4, 5);
            int resultadoEsperado = -1;
            Assert.That(resultadoSoma, Is.EqualTo(resultadoEsperado));
        }

        [Test]
        public void TestSubtrairComValoresZero()
        {
            int resultadoSoma = calculadora.subtrair(0, 0);
            int resultadoEsperado = 0;
            Assert.That(resultadoSoma, Is.EqualTo(resultadoEsperado));
        }

        [Test]
        public void TestMultiplicacao()
        {
            int resultadoSoma = calculadora.multiplicar(5, 5);
            int resultadoEsperado = 25;
            Assert.That(resultadoSoma, Is.EqualTo(resultadoEsperado));
        }

        [Test]
        public void TestMultiplicacaoComValorNegativo()
        {
            int resultadoSoma = calculadora.multiplicar(-5, 5);
            int resultadoEsperado = -25;
            Assert.That(resultadoSoma, Is.EqualTo(resultadoEsperado));
        }

        [Test]
        public void TestMultiplicacaoComValorZero()
        {
            int resultadoSoma = calculadora.multiplicar(0, 5);
            int resultadoEsperado = 0;
            Assert.That(resultadoSoma, Is.EqualTo(resultadoEsperado));
        }

        [Test]
        public void TestDivisao()
        {
            int resultadoSoma = calculadora.dividir(5, 5);
            int resultadoEsperado = 1;
            Assert.That(resultadoSoma, Is.EqualTo(resultadoEsperado));
        }

        [Test]
        public void TestDivisaoComValorNegativo()
        {
            int resultadoSoma = calculadora.dividir(-5, 5);
            int resultadoEsperado = -1;
            Assert.That(resultadoSoma, Is.EqualTo(resultadoEsperado));
        }

        [Test]
        public void TestDivisaoComValorZero()
        {
            Assert.Throws<DivideByZeroException>(() => calculadora.dividir(5, 0));
        }
    }
}
