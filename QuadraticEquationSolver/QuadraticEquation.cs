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
    }
}
