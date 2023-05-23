using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Classes;

namespace TS.Interfaces
{
    public interface IRepositorio
    {
        int Salvar(Pessoa pessoa);
    }
}
