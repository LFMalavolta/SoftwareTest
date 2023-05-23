using TS.Classes;

namespace TS_Test.Classes
{
    internal class TextoTest
    {
        Texto texto;

        [SetUp]
        public void Setup()
        {
            texto = new Texto();
        }

        [Test]
        public void TestTamanhoTextoZero()
        {
            string texto = "";
            int resultadoTeste = this.texto.retornaTamanhoTexto(texto);
            int tamanhoEsperado = 0;
            Assert.That(resultadoTeste, Is.EqualTo(tamanhoEsperado));
        }

        [Test]
        public void TestTamanhoTexto10()
        {
            string texto = "abcdefghij";
            int resultadoTeste = this.texto.retornaTamanhoTexto(texto);
            int tamanhoEsperado = 10;
            Assert.That(resultadoTeste, Is.EqualTo(tamanhoEsperado));
        }
    }
}
