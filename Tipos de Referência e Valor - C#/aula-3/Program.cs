using System;
using static System.Console;

namespace aula_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();

            p1.Nome = "João Lucas";
            p1.Idade = 23;

            p1.EnderecoPessoa = new Endereco()
            {
            Logradouro = "Rua teste",
            Numero = 300,
            CEP = "000000",
            Cidade = "Teresina",
            };

            WriteLine("Fim");
        }
    }
}
