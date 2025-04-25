using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfiaTrab
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }

        public virtual string mostra()
        {
            return $"Nome: {Nome}\nSalário: {Salario}";
        }

        public virtual double CalculoSalario()
        {      
            return Salario;
        }
}
}
