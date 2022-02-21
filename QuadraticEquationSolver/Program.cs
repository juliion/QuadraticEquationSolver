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
                try
                {
                    string filename = args[0];
                    if (File.Exists(filename))
                    {
                        string str = File.ReadAllText(filename);
                        string[] coefStr = str.Split(' ');
                        double[] coef = new double[coefStr.Length];
                        for (int i = 0; i < coefStr.Length; i++)
                        {
                            if (!double.TryParse(coefStr[i], out coef[i]))
                                throw new Exception("invalid file format");
                        }
                        if (coef[0] == 0)
                            throw new Exception("a cannot be 0");
                        QuadraticEquation qm = new QuadraticEquation()
                        {
                            A = coef[0],
                            B = coef[1],
                            C = coef[2]
                        };
                        qm.Solve();
                    }
                    else
                        throw new Exception($"file {filename} does not exist");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }
            }
            else
            {
                double a, b, c;
                do
                {
                    Console.Write("Enter a: ");
                    Console.Clear();
                } while (!double.TryParse(Console.ReadLine(), out a) || a == 0);
                do
                {
                    Console.Write("Enter b: ");
                    Console.Clear();
                } while (!double.TryParse(Console.ReadLine(), out b));
                do
                {
                    Console.Write("Enter с: ");
                    Console.Clear();
                } while (!double.TryParse(Console.ReadLine(), out c));
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