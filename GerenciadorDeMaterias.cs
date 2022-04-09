using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooControleDeNotas
{
    public class GerenciadorDeMaterias
    {
        public GerenciadorDeMaterias()
        {
            this.Estudante = new Aluno();
            this.materias = new List<Materia>();
        }

        public GerenciadorDeMaterias(String nome, String email)
        {
            this.Estudante = new Aluno(nome, email);
            this.materias = new List<Materia>();
        }

        public Aluno Estudante { get; set; }
        private List<Materia> materias;
        public List<Materia> Materias
        {
            get
            {
                return this.materias;
            }
        }

        // métodos para controlar as matérias
        public void CadastrarMateria(Materia materia)
        {
            try
            {
                if (this.materias.Exists(m => m.Nome == materia.Nome))
                {
                    throw new Exception("Matéria já cadastrada! ");
                }
                else
                {
                    materias.Add(materia);
                }
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

       public void ListarMaterias()
        {
            Console.WriteLine("**** Matérias ****");
            for (int i = 0; i < materias.Count; i++)
            {
                Materia m = materias[i];
                m.ExibirDados();
                Console.WriteLine("********");
            }
        }

        public Boolean ExcluirMateria(String nome)
        {
            Boolean retorno = false;
            if (this.materias.Exists(m => m.Nome == nome))
            {
                retorno = true;
                Materia materia = this.materias.Find(m => m.Nome == nome);
                this.materias.Remove(materia);
            }
            return retorno;
        }

        public Boolean AlterarMateria(Materia materia)
        {
            Boolean retorno = false;
            if (this.materias.Exists(m => m.Nome == materia.Nome))
            {
                retorno = true;
                Materia materiaNew = this.materias.Find(m => m.Nome == materia.Nome);
                materiaNew.Nota1 = materia.Nota1;            
                materiaNew.Nota2 = materia.Nota2;
            }
            return retorno;
        }
    }
}
