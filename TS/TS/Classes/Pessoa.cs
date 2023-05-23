using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TS.Classes
{
    public class Pessoa
    {
        public int idade;
        public string ConcatenaNomeSobreNome(string nome, string sobreNome)
        {
            return nome + sobreNome;
        }

        public bool EMaiorDeIdade(int idade)
        {
            return idade >= 18;
        }

        public bool cpfValido(int cpf)
        {
            if (cpf > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool nameValido(string nome)
        {
            if (nome.Equals(""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }

}
