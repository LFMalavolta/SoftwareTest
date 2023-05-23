using Moq;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Classes;
using TS.Classes.ExerciciosE1;
using TS.Interfaces;

namespace TS_Test.Classes.Exercicios_E1
{
    public class ValidaCarroTest
    {
        private Carro carro;
        private ValidaCarro valida;

        [SetUp]
        public void Setup()
        {
            carro = new Carro()
            {
                codigo = 1,
                modelo = "Onix",
                marca = "GM",
                placa = "IEV-7889",
                anoFabricacao = 2023,
                nomeProprietario = "Teste",
                valorTotal = 45000,
                eFinanciado = false,
                valorFinanciamento = 0
            };
            valida = new ValidaCarro();
        }

        [Test]
        public void TestValidaCarroSucessoComMock()
        {
            Mock<IValidarCarro> mock = new Mock<IValidarCarro>();
            mock.Setup(m => m.ValidarCarro(It.IsAny<Carro>())).Returns(true);
            bool resultadoTeste = mock.Object.ValidarCarro(carro);
            Assert.That(resultadoTeste, Is.True);
        }
        [Test]
        public void TestValidaCarroErroComMock()
        {
            Mock<IValidarCarro> mock = new Mock<IValidarCarro>();
            mock.Setup(m => m.ValidarCarro(It.IsAny<Carro>())).Returns(false);
            bool resultadoTeste = mock.Object.ValidarCarro(carro);
            Assert.That(resultadoTeste, Is.False);
        }


        [Test]
        public void TestValidaCarroIdSucesso()
        {
            carro.codigo = 1;
            bool resultadoTeste = valida.ValidarCarro(carro);
            Assert.That(resultadoTeste, Is.True);
        }
        [Test]
        public void TestValidaCarroIdErro()
        {
            carro.codigo = 0;
            bool resultadoTeste = valida.ValidarCarro(carro);
            Assert.That(resultadoTeste, Is.False);
        }

        [Test]
        public void TestValidaCarroModeloSucesso()
        {
            carro.modelo = "Onix";
            bool resultadoTeste = valida.ValidarCarro(carro);
            Assert.That(resultadoTeste, Is.True);
        }

        [Test]
        public void TestValidaCarroModeloErro()
        {
            carro.modelo = "testetetetetetetettetetetetetetet";
            bool resultadoTeste = valida.ValidarCarro(carro);
            Assert.That(resultadoTeste, Is.False);
        }

        [Test]
        public void TestValidaCarroMarcaSucesso()
        {
            carro.marca = "GM";
            bool resultadoTeste = valida.ValidarCarro(carro);
            Assert.That(resultadoTeste, Is.True);
        }
        [Test]
        public void TestValidaCarroMarcaErro()
        {
            carro.marca = "testetetetetetetettetetetetetetet";
            bool resultadoTeste = valida.ValidarCarro(carro);
            Assert.That(resultadoTeste, Is.False);
        }

        [Test]
        public void TestValidaCarroAnoFabricacaoSucesso()
        {
            carro.anoFabricacao = 2023;
            bool resultadoTeste = valida.ValidarCarro(carro);
            Assert.That(resultadoTeste, Is.True);
        }
        [Test]
        public void TestValidaCarroAnoFabricacaoErro()
        {
            carro.anoFabricacao = 1950;
            bool resultadoTeste = valida.ValidarCarro(carro);
            Assert.That(resultadoTeste, Is.False);
        }

        [Test]
        public void TestValidaCarroNomeProprietarioSucesso()
        {
            carro.nomeProprietario = "teste";
            bool resultadoTeste = valida.ValidarCarro(carro);
            Assert.That(resultadoTeste, Is.True);
        }
        [Test]
        public void TestValidaCarroNomeProprietarioErro()
        {
            carro.nomeProprietario = "testetetetetetetettetetetetetetet";
            bool resultadoTeste = valida.ValidarCarro(carro);
            Assert.That(resultadoTeste, Is.False);
        }

        [Test]
        public void TestValidaCarroValorTotalSucesso()
        {
            carro.valorTotal = 45000;
            bool resultadoTeste = valida.ValidarCarro(carro);
            Assert.That(resultadoTeste, Is.True);
        }
        [Test]
        public void TestValidaCarroValorTotalErro()
        {
            carro.valorTotal = 0;
            bool resultadoTeste = valida.ValidarCarro(carro);
            Assert.That(resultadoTeste, Is.False);
        }

        [Test]
        public void TestValidaCarroFinanciamentoSucesso()
        {
            carro.eFinanciado = true;
            carro.valorFinanciamento = 20000;
            bool resultadoTeste = valida.ValidarCarro(carro);
            Assert.That(resultadoTeste, Is.True);
        }
        [Test]
        public void TestValidaCarroFinanciamentoErro()
        {
            carro.eFinanciado = true;
            carro.valorFinanciamento = 0;
            bool resultadoTeste = valida.ValidarCarro(carro);
            Assert.That(resultadoTeste, Is.False);
        }
    }
}
