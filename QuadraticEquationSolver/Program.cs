using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace QuadraticEquationSolver
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if(args.Length == 1)
            {
                string filename  = args[0];
                if(File.Exists(filename))
                {
                    string str = File.ReadAllText(filename);
                    string[] coefStr = str.Split(' ');
                    double[] coef = new double[coefStr.Length];
                    for (int i = 0; i < coefStr.Length; i++)
                    {
                        coef[i] = double.Parse(coefStr[i]);
                    }
                    QuadraticEquation qm = new QuadraticEquation()
                    {
                        A = coef[0],
                        B = coef[1],
                        C = coef[2]
                    };
                    qm.Solve();
                }
            }
            else
            {
                string buff;
                double a, b, c;
                do
                {
                    Console.Write("Enter a: ");
                    buff = Console.ReadLine();
                    Console.Clear();
                } while (!double.TryParse(buff, out a) || a == 0);
                do
                {
                    Console.Write("Enter b: ");
                    buff = Console.ReadLine();
                    Console.Clear();
                } while (!double.TryParse(buff, out b));
                do
                {
                    Console.Write("Enter с: ");
                    buff = Console.ReadLine();
                    Console.Clear();
                } while (!double.TryParse(buff, out c));
                QuadraticEquation qm = new QuadraticEquation()
                {
                    A = a,
                    B = b,
                    C = c
                };
                qm.Solve();
            }
        }
    }
}