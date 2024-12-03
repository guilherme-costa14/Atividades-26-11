using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicios exc = new Exercicios();
            //exc.Resultado();
            Calculadora calc = new Calculadora();
            double result = calc.Somar(3, 2);
            Console.WriteLine("Adição: " + result);
            result = calc.Subtrair(5.8, 9);
            Console.WriteLine("Subtração: " + result);
            result = calc.Dividir(6, 3);
            Console.WriteLine("Divisão: " + result);
            result = calc.Multiplicar(6.5, 3);
            Console.WriteLine("Multiplicação: " + result);
        }
    }
}
