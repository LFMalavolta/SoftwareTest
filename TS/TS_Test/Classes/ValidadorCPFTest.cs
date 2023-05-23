using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Classes;

namespace TS_Test.Classes
{
    public class ValidadorCPFTest
    {
        Pessoa pessoa;
        [SetUp]
        public void Setup()
        {
            pessoa = new Pessoa();
        }

        [Test]
        public void TestECPFValido()
        {
            int entrada = 1823423423;
            bool resultadoTeste = pessoa.cpfValido(entrada);
            Assert.That(resultadoTeste, Is.True);
        }

        [Test]
        public void TestECPFZero()
        {
            int entrada = 0;
            bool resultadoTeste = pessoa.cpfValido(entrada);
            Assert.That(resultadoTeste, Is.False);
        }
    }
}
