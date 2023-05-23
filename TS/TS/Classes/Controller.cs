using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using TS.Interfaces;

namespace TS.Classes
{
    public class Controller
    {
        private IRepositorio repositorio;

        public Controller(IRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public int SalvarPessoa(Pessoa pessoa)
        {
            int resultado = 0;
            Console.WriteLine("Iniciando processamento salvarPessoa");
            try
            {
                resultado = repositorio.Salvar(pessoa);
                Console.WriteLine("SUCESSO do processamento salvarPessoa");
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERRO do processamento salvarPessoa");
                throw ex;
            }
            Console.WriteLine("Fim do processamento salvarPessoa");
            return resultado;
        }

    }
}
