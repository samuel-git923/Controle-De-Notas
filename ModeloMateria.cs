using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooControleDeNotas
{
    abstract public class ModeloMateria
    {
        public String Nome { get; set; }
        public Double Nota1 { get; set; }
        public Double Nota2 { get; set; }

        abstract public void ExibirDados();
    }
}
