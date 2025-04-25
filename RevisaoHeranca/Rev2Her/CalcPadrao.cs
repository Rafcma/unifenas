using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rev2Her
{
    internal class CalcPadrao
    {
        protected double regx;
        protected double regy;

        public CalcPadrao(double regx, double regy)
        {
            this.regx = regx;
            this.regy = regy;
        }
        public double Soma()
        {
            return regx + regy;
        }
        public double Subtrai()
        {
            return regx - regy;
        }
    }
}
