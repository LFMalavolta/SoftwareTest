using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Classes;

namespace TS_Test.Classes
{
    internal class PessoaTest
    {
        Pessoa pessoa;
        [SetUp]
        public void Setup()
        {
            pessoa = new Pessoa();
        }

        [Test]
        public void TestConcatenaNomeSobreNome()
        {
            string nome = "Pedro";
            string sobreNome = "Silva";
            string resultadoPrograma = pessoa.ConcatenaNomeSobreNome(nome, sobreNome);
            Assert.That(resultadoPrograma, Is.EqualTo("PedroSilva"));
        }

        [Test]
        public void TestEMaiorDeIdade()
        {
            int entrada = 18;
            bool resultadoTeste = pessoa.EMaiorDeIdade(entrada);
            Assert.That(resultadoTeste, Is.True);
        }

        [Test]
        public void TestNomeValido()
        {
            string entrada = "Teste";
            bool resultadoTeste = pessoa.nameValido(entrada);
            Assert.That(resultadoTeste, Is.True);
        }

        [Test]
        public void TestNomeInvalido()
        {
            string entrada = "";
            bool resultadoTeste = pessoa.nameValido(entrada);
            Assert.That(resultadoTeste, Is.False);
        }
    }
}
