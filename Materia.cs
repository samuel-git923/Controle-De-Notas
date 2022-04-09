
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooControleDeNotas
{
    public class Materia : ModeloMateria
    {
        public Materia()
        {
            this.Nome = "";
            this.Nota1 = 0;
            this.Nota2 = 0;
            this.MediaAprovacao = 5;
        }

        public Materia(String nome, Double nota1, Double nota2, Double mediaAprovacao)
        {
            this.Nome = nome;
            this.Nota1 = nota1;
            this.Nota2 = nota2;
            this.MediaAprovacao = mediaAprovacao;
        }

        public Double MediaAprovacao { get; set; }
        public Double Media 
        {
            get
            {
                return (this.Nota1 + this.Nota2) / 2;
            } 
        }
        public override void ExibirDados()
        {
            Console.WriteLine("Matéria: " + this.Nome);
            Console.WriteLine("1ª nota: " + this.Nota1);
            Console.WriteLine("2ª nota: " + this.Nota2);
            Console.WriteLine("Média: " + this.Media);
            Console.WriteLine("Média para aprovaçãp: " + this.MediaAprovacao);
            Console.WriteLine("Status da matéria: " + this.StatusMateria());
        }

        public String StatusMateria()
        {
            String msg = "Aluno não aprovado!";
            if (this.Media >= this.MediaAprovacao)
            {
                msg = "Aluno aprovado!";
            }
            return msg;
        }
    }
}
