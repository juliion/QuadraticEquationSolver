using System;
using System.Collections.Generic;
using System.Linq;

namespace QuadraticEquationSolver
{
    public class Program
    {
        public static void Main(string[] args)
        {
            QuadraticEquation qe = new QuadraticEquation();
            qe.A = 1;
            qe.B = 5;
            qe.C = -6;
            qe.Solve();
        }
    }
}