using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfiaTrab
{
    internal class Gestor : Funcionario
    {
        public string Cargo { get; set; }

        public override string mostra()
        {
            return base.mostra() + $"\nCargo: {Cargo}";
        }

        public override double CalculoSalario()
        {
            return Salario + 2000.00;
        }
    }
}
