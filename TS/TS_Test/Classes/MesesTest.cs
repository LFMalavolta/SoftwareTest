using TS.Classes;

namespace TS_Test.Classes
{
    internal class MesesTest
    {
        Meses meses;

        [SetUp]
        public void Setup()
        {
            meses = new Meses();
        }

        [Test]
        public void TestValidaMesZero()
        {
            int mes = 0;
            bool resultadoTeste = meses.validaMes(mes);
            Assert.That(resultadoTeste, Is.False);
        }

        [Test]
        public void TestValidaMesEntre1e12()
        {
            int mes = 1;
            bool resultadoTeste = meses.validaMes(mes);
            Assert.That(resultadoTeste, Is.True);

            mes = 12;
            resultadoTeste = meses.validaMes(mes);
            Assert.That(resultadoTeste, Is.True);
        }

        [Test]
        public void TestValidaMesMaior12()
        {
            int mes = 13;
            bool resultadoTeste = meses.validaMes(mes);
            Assert.That(resultadoTeste, Is.False);
        }
    }
}
