using System;

namespace Calculos
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1;
            double numero2;
            double soma;
            string operacao;

            Console.Write("Digite o primeiro numero: ");
            numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a operação: ");
            operacao = Console.ReadLine();

            Console.Write("Digite o segundo numero: ");
            numero2 = Convert.ToDouble(Console.ReadLine());

            soma = 0;

            if (operacao == "+")
            {
                soma = numero1 + numero2;
            }

            else if (operacao == "-")
            {
                soma = numero1 - numero2;
            }

            else if (operacao == "*")
            {
                soma = numero1 * numero2;
            }

            else if (operacao == "/")
            {
                soma = numero1 / numero2;
            }
                                  
            Console.WriteLine("O resultado é " + soma);
            Console.ReadKey();

        }
    }
}
