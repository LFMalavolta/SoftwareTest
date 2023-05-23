using Moq;
using TS.Classes;
using TS.Interfaces;

namespace TS_Test.Classes
{
    public class ControllerTest
    {
        private Controller controller;
        private Repositorio repositorio;

        [SetUp]
        public void Setup()
        {
            Mock<IRepositorio> mock = new Mock<IRepositorio>();
            mock.Setup(m => m.Salvar(It.IsAny<Pessoa>())).Returns(3);
            controller = new Controller(mock.Object);
        }

        [Test]
        public void TestSalvarPessoaComSucesso()
        {
            // arrange
            Pessoa pessoa = new Pessoa();


            // act
            int resultado = controller.SalvarPessoa(pessoa);


            // assert
            Assert.IsTrue(resultado > 0);
        }

        [Test]
        public void TestSalvarPessoaComErro()
        {
            // arrange
            Pessoa pessoa = new Pessoa();
            pessoa.idade = -1;

            // act, assert
            Assert.Throws<Exception>(() => 
                    controller.SalvarPessoa(pessoa));
        }
    }
}
