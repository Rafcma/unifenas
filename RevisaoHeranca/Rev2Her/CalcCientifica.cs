using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Rev2Her
{
    internal class CalcCientifica:CalcPadrao
    {
        public CalcCientifica(double regx, double regy):base(regx, regy) { }

        public double CuboRegx()
        {
            return regx * regx * regx;
        }
    }
}
