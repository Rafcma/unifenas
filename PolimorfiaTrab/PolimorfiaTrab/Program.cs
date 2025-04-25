using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfiaTrab
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    internal class Program
    {
        static void Main()
        {
            List<Funcionario> lista = new List<Funcionario>();
            Gestor g;
            Vendedor v;
            int op;
            do
            {
                Console.Clear();
                Console.WriteLine("// Menu de Opções //");
                Console.WriteLine("1. Cadastrar Gestor");
                Console.WriteLine("2. Cadastrar Vendedor");
                Console.WriteLine("3. Mostrar Dados de Gestor e Vendedor");
                Console.WriteLine("4. Mostrar Salários de um determinado Funcionário");
                Console.WriteLine("5. Sair");
                Console.Write("Digite sua opção: ");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        g = new Gestor();
                        cadastro(g);

                        Console.Write("\nCargo: ");
                        g.Cargo = Console.ReadLine();
                        lista.Add(g);
                        break;
                    case 2:
                        v = new Vendedor();
                        cadastro(v);

                        Console.Write("\nValor referente às Vendas: ");
                        v.Vendas = double.Parse(Console.ReadLine());

                        lista.Add(v);
                        break;
                    case 3:
                        for (int i = 0; i < lista.Count; i++)
                        {
                            Console.WriteLine(lista[i].mostra());
                        }

                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Write("\nNome: ");
                        string pesquisa = Console.ReadLine();
                        for (int i = 0; i < lista.Count; i++)
                        {
                            if (lista[i].Nome == pesquisa)
                            {
                                Console.WriteLine(lista[i].mostra());
                                Console.WriteLine("\nSalário: " + lista[i].CalculoSalario().ToString("0.00"));
                            }
                        }

                        Console.ReadKey();
                        break;
                }
            } while (op != 5);
        }
        static void cadastro(Funcionario f)
        {
            Console.Write("\nNome: ");
            f.Nome = Console.ReadLine();
            Console.Write("\nSalário: ");
            f.Salario = double.Parse(Console.ReadLine());
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }

}
