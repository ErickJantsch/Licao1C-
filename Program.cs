using System;

namespace Licao_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" 1) Faca um progarama para ler dois valores inteiros, e depois mostrar na tela a\n" +
                 " desses numros com uma mensagen explicativa, conforme exemplos.");

            Console.WriteLine("Informe o numero de a:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o numero de b:");
            Console.WriteLine();
            int num2 = int.Parse(Console.ReadLine());
            int soma = num1 + num2;
            Console.WriteLine("A soma e: " + soma);
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------");
        }
    }
}
