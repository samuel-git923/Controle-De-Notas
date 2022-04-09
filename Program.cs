using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooControleDeNotas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            String NomeMateria = "";
            Double n1 = 0, n2 = 0, mo = 5;
            Materia materia;
            GerenciadorDeMaterias gm = new GerenciadorDeMaterias("Samuel Bacellar", "samuelbacellar1@gmail.com");
            // implementar o cadastro do aluno
            while (op != 5)
            {
                Console.WriteLine("Controle de Matérias");
                gm.Estudante.ExibirDados();
                op = ExibirMenu();
                Console.Clear();
                if (op == 1)
                { //exibir matérias
                    gm.ListarMaterias();
                }
                if (op == 2)
                { //cadastrar matérias
                    try
                    {
                        Console.WriteLine("Cadastro de matérias");
                        Console.Write("Matéria: ");
                        NomeMateria = Console.ReadLine();
                        Console.Write("Nota 1: ");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Nota 2: ");
                        n2 = Convert.ToDouble(Console.ReadLine());
                        // gm cadastrar uma materia
                        materia = new Materia(NomeMateria, n1, n2, mo);
                        gm.CadastrarMateria(materia);
                        Console.WriteLine("Matéria Cadastrada!");
                    }
                    catch (Exception erro)
                    {
                        Console.WriteLine(erro.Message + "Tente novamente!");
                    }

                }
                if (op == 3)
                { //alterar matérias
                    try
                    {
                        Console.WriteLine("Alterar matéria");
                        Console.Write("Matéria: ");
                        NomeMateria = Console.ReadLine();
                        Console.Write("Nota 1: ");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Nota 2: ");
                        n2 = Convert.ToDouble(Console.ReadLine());
                        // gm cadastrar uma materia
                        materia = new Materia(NomeMateria, n1, n2, mo);
                        if (gm.AlterarMateria(materia))
                        {
                            Console.WriteLine("Matéria Alterada!");
                        }
                        else
                        {
                            Console.WriteLine("Matéria não encontrada!");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Matéria não alterada. Tente novamente!");
                    }
                }
                if (op == 4)
                { //excluir matérias
                    Console.WriteLine("Excluir uma matéria");
                    Console.Write("Matéria: ");
                    NomeMateria = Console.ReadLine();
                    if (gm.ExcluirMateria(NomeMateria))
                    {
                        Console.WriteLine("Matéria Excluída!");
                    }
                    else
                    {
                        Console.WriteLine("Matéria não encontrada!");
                    }
                }
                Console.ReadKey();
            }
            Console.ReadKey();
        }

        static int ExibirMenu()
        {
            int op = 0;
            try
            {
                while (op < 1 || op > 5)
                {
                    Console.WriteLine("1 - Exibir Matérias");
                    Console.WriteLine("2 - Cadastrar Matérias");
                    Console.WriteLine("3 - Alterar dados das matérias");
                    Console.WriteLine("4 - Excluir uma matéria");
                    Console.WriteLine("5 - Sair do sistema");
                    Console.Write("Opção: ");
                    op = Convert.ToInt32(Console.ReadLine());     
                }
            }
            catch
            {
                op = 0;
            }
            return op;
        }
    }
}
