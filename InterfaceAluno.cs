using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooControleDeNotas
{
    interface InterfaceAluno
    {
        String Nome { get; set; }
        String Email { get; set; }
        void ExibirDados();
    }
}
