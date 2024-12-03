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
            while (true)
            {
                Console.WriteLine("Escolha uma operação: 1 - Adição, 2 - Subtrair, 3 - Divisão, 4 - Multiplicação");
                Console.WriteLine("x - sair");
                string opcao = Console.ReadLine();
                if(opcao == "1")
                {
                    Console.WriteLine("Digite o primeiro número: ");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número: ");
                    int num2 = int.Parse(Console.ReadLine());

                }

            }

            //Console.ReadKey(); 
        }
    }
}
