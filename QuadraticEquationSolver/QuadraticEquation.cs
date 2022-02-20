using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquationSolver
{
    public class QuadraticEquation
    {
        public double A { get; set; }  
        public double B { get; set; }  
        public double C { get; set; }
        public double CalcDiscriminant()
        {
            return B * B - 4 * A * C;
        }
        public double CalcX(double sqrtD)
        {
            return (-1 * B + sqrtD) / (2 * A);
        }
        public override string? ToString()
        {
            string res = $"";
            if (A == 1)
                res += "x^2";
            else if (A != 0)
                res += $"{A}x^2";
            if (B > 0)
                res += $" + {B}x";
            else if(B < 0)
                res += $" - {B * -1}x";
            if (C > 0)
                res += $" + {C}";
            else if (C < 0)
                res += $" - {C * -1}";
            res += " = 0";
            return res;
        }
    }
}
