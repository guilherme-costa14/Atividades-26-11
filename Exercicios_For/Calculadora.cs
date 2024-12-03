using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_For
{
    internal class Calculadora
    {
        public double Somar(double num1, double num2)
        {
            double resultado = 0;
            resultado = num1 + num2;
            return resultado;
        }
        public double Subtrair(double num1, double num2)
        {
            double resultado = 0;
            resultado = num1 - num2;
            return resultado;
        }
        public double Dividir(double num1, double num2)
        {
            double resultado = 0;
            resultado = num1 / num2;
            return resultado;
        }
        public double Multiplicar(double num1, double num2)
        {
            double resultado = 0;
            resultado = num1 * num2;
            return resultado;
        }
    }
}
