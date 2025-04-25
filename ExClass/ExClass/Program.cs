using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ExClass
{
    internal class Program
    {
        class IMCorporal
        {
            private double peso;
            private double altura;

            public void Gravar()
            {
                Console.WriteLine("Digite o peso: ");
                peso = double.Parse(Console.ReadLine());

                Console.WriteLine("\nDigite a altura: ");
                altura = double.Parse(Console.ReadLine());
            }

            public double CalculaIMC()
            {
                return peso / (altura * altura);
            }

            public void MostrarIMC(double imc)
            {
                Console.WriteLine($"\nAltura = {altura}");
                Console.WriteLine($"\nPeso = {peso}");
                Console.WriteLine($"\nIMC = {imc}");
            }
        }

        static void Main()
        {
            IMCorporal resultado = new IMCorporal();
            resultado.Gravar();
            double imc = resultado.CalculaIMC();
            resultado.MostrarIMC(imc);

            Console.ReadKey();
        }
    }
}

