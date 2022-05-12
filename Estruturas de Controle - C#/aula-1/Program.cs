using System;
using static System.Console;

namespace aula_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1;
            int valor2;

            WriteLine("Digite o primeiro valor:");
            valor1 = int.Parse(ReadLine());
            WriteLine("Primeiro valor é: " + valor1);

            WriteLine("Digite o segundo valor:");
            valor2 = int.Parse(ReadLine());
            WriteLine("Segundo valor é: " + valor2);

            int total = valor1 + valor2;

            WriteLine($"A soma dos 2 valores é: {total}");
        }
    }
}
