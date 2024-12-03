using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_For
{
    internal class Exercicios
    {
        public void Teste()
        {
            Console.WriteLine("Testando");
        }

        public void Resultado()
        {
            //1.Escreva um programa que verifique se um número fornecido pelo usuário é positivo, negativo ou zero.

            //2.Escreva um programa que leia um mês do ano e informe quantos dias ele tem.

            //3.Faça um programa que leia a nota de um aluno e informe se ele está aprovado(nota maior ou igual a 7), em recuperação(nota entre 5 e 7) ou reprovado(nota menor que 5).

            //4.Calcule a soma de todos os números de 1 a 100 utilizando um laço de repetição.

            //5.Implemente uma contagem regressiva de 10 até 0 utilizando um laço de repetição.

            //6. Faça um programa que leia o nome de um aluno e suas três notas, calcule a média e informe se ele está aprovado(média maior ou igual a 7) ou reprovado.

            //Desafio - Descobrir se o ano informado pelo usuário é bissexto

            //Desafio - Jogo da adivinhação: Implemente um jogo de adivinhação onde o usuário tem que adivinhar um número entre 1 e 100. O programa deve dar dicas de "maior" ou "menor" após cada tentativa, utilizando um laço de repetição.
            while (true)
            {
                Console.WriteLine("Escolha uma atividade: 1 - veriPositivo, 2 - mesDias, 3 - notaAprov, 4 - calcularSoma, 5 - contRegressiva, 6 - calMedia, 7 - bissexto, 8 - jogoAdivinhacao");
                Console.WriteLine("x - sair");
                string opcao = Console.ReadLine();
                if (opcao == "x")
                {
                    break;
                }
                else if (opcao == "1")
                {
                    veriPositivo();
                }
                else if (opcao == "2")
                {
                    mesDias();
                }
                else if (opcao == "3")
                {
                    notaAprov();
                }
                else if (opcao == "4")
                {
                    calcularSoma();
                }
                else if (opcao == "5")
                {
                    contRegressiva();
                }
                else if (opcao == "6")
                {
                    calMedia();
                }
                else if (opcao == "7")
                {
                    bissexto();
                }
                else if (opcao == "8")
                {
                    jogoAdivinhacao();
                }
            }
            
            void jogoAdivinhacao()
            {
                int numUsuario = 0;
                Random rnd = new Random();
                int sortiado = rnd.Next(1, 100);
                while (true)
                {
                    Console.WriteLine("Digite um valor: ");
                    numUsuario = int.Parse(Console.ReadLine());
                    if (numUsuario == sortiado)
                    {
                        Console.WriteLine("Parabéns você acertou o número sortiado!");
                        break;
                    }
                    else if (numUsuario > sortiado)
                    {
                        Console.WriteLine("O número digitado é maior do que o sortiado. Tente novamente");
                    }
                    else
                    {
                        Console.WriteLine("O número digitado é menor do que o sortiado. Tente novamente");
                    }
                }
            }

            void veriPositivo()
            {
                int num = 0;
                Console.Write("Digite um número: ");
                num = int.Parse(Console.ReadLine());
                if (num > 0)
                {
                    Console.WriteLine("O número digitado é positivo.");
                }
                else if (num < 0)
                {
                    Console.WriteLine("O número digitado é negativo.");
                }
                else
                {
                    Console.WriteLine("Número igual a 0.");
                }
            }

            void mesDias()
            {
                int mes = 0;
                Console.Write("Digite o n° do mês: ");
                mes = int.Parse(Console.ReadLine());
                if (mes == 1)
                {
                    Console.WriteLine("O mês de janeiro tem 31 dias.");
                }
                else if (mes == 2)
                {
                    Console.WriteLine("O mês de fevereiro tem 28 dias.");
                }
                else if (mes == 3)
                {
                    Console.WriteLine("O mês de março tem 31 dias.");
                }
                else if (mes == 4)
                {
                    Console.WriteLine("O mês de abril tem 30 dias");
                }
                else if (mes == 5)
                {
                    Console.WriteLine("O mês de maio tem 31 dias");
                }
                else if (mes == 6)
                {
                    Console.WriteLine("O mês de junho tem 30 dias.");
                }
                else if (mes == 7)
                {
                    Console.WriteLine("O mês de julho tem 31 dias.");
                }
                else if (mes == 8)
                {
                    Console.WriteLine("O mês de agosto tem 31 dias.");
                }
                else if (mes == 9)
                {
                    Console.WriteLine("O mês de setembro tem 30 dias.");
                }
                else if (mes == 10)
                {
                    Console.WriteLine("O mês de outubro tem 31 dias.");
                }
                else if (mes == 11)
                {
                    Console.WriteLine("O mês de novembro tem 30 dias.");
                }
                else if (mes == 12)
                {
                    Console.WriteLine("O mês de dezembro tem 31 dias.");
                }
            }

            void notaAprov()
            {
                int nota = 0;
                Console.Write("Digite a sua nota: ");
                nota = int.Parse(Console.ReadLine());
                if (nota >= 7)
                {
                    Console.WriteLine("Você está aprovado");
                }
                else if (nota >= 5 && nota <= 7)
                {
                    Console.WriteLine("Você está de recuperação");
                }
                else
                {
                    Console.WriteLine("Você está reprovado.");
                }
            }

            void calcularSoma()
            {
                int i = 1;
                int soma = 0;
                while (i <= 100)
                {
                    soma += i;
                    i++;
                }
                Console.WriteLine(soma);
            }

            void contRegressiva()
            {
                int i = 10;
                while (i >= 0)
                {
                    Console.WriteLine(i);
                    i--;
                }
            }

            void calMedia()
            {
                string nome = "";
                double nt1 = 0;
                double nt2 = 0;
                double nt3 = 0;
                double media = 0;
                Console.Write("Digite seu nome: ");
                nome = Console.ReadLine();
                Console.Write("Digite o valor da primeira nota: ");
                nt1 = double.Parse(Console.ReadLine());
                Console.Write("Digite o valor da primeira nota: ");
                nt2 = double.Parse(Console.ReadLine());
                Console.Write("Digite o valor da primeira nota: ");
                nt3 = double.Parse(Console.ReadLine());
                media = (nt1 + nt2 + nt3) / 3;
                if (media >= 7)
                {
                    Console.WriteLine(media.ToString("F") + " " + nome + " você está aprovado.");
                }
                else
                {
                    Console.WriteLine(media.ToString("F") + " " + nome + " você está reprovado.");
                }
            }

            void bissexto()
            {
                int ano = 0;
                Console.Write("Digite o valor de um ano: ");
                ano = int.Parse(Console.ReadLine());
                if (ano % 4 == 0 && ano % 100 != 0)
                {
                    Console.WriteLine("O ano provavelmente é bissexto");
                }
                else
                {
                    Console.WriteLine("O ano provavelmente não é bissexto");
                }
            }
        }
    }
}
