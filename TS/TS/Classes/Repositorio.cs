using TS.Interfaces;

namespace TS.Classes
{
    /// <summary>
    /// se nao conseguir salvar, vai gerar uma excessao
    /// </summary>
    public class Repositorio : IRepositorio
    {
        public int Salvar(Pessoa pessoa) 
        {
            Console.WriteLine("salvando no banco de dados");
            if (pessoa.idade == -1) 
            {
                throw new Exception();
            }
            return 1;
        }
    }
}
