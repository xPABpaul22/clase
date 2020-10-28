using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class EquationSolver
    {
        public static Equation2Sol SolveEquation2(double a, double b, double c)
        {
            double aux, root;
            Equation2Sol result;
            result = new Equation2Sol();
            aux = b * b - 4.0 * a * c;
            root = System.Math.Sqrt(aux);
            result.suma = (-b + root) / (2.0 * a);
            result.resta = (-b - root) / (2.0 * a);
            return result;
        }
    }
}
