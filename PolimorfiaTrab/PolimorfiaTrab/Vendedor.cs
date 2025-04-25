using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfiaTrab
{
    internal class Vendedor : Funcionario
    {
        public double Vendas { get; set; }

        public override string mostra()
        {
            return base.mostra() + $"\nVendas: {Vendas}";
        }

        public override double CalculoSalario()
        {
            return Salario + (0.4 * Vendas);
        }
    }
}
