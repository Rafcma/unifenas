using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rev2Her
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalcCientifica CT = new CalcCientifica(4, 5);
            Console.WriteLine("Calculadora Cientifica: ");
            Console.WriteLine($"Soma: {CT.Soma()} ");
            Console.WriteLine($"Subtração: {CT.Subtrai()}  ");
            Console.WriteLine($"Cubo de X: {CT.CuboRegx()} ");
            Console.ReadKey();
        }
    }
}
