using System;

namespace primeiroApp
{
    class Program
    {
         static void InstrucaoIf(string[] texto)
        {
            if (texto.Length == 0)
            {
                Console.WriteLine("Nenhum argumento");
            }
            else if (texto.Length == 1)
            {
                Console.WriteLine("Um argumento");
            }
            else
            {
                Console.WriteLine($"{texto.Length} argumentos");
            }
        }
         static void InstrucaoSwitch(string[] texto)
        {
            int numeroDeArgumentos = texto.Length;
            switch (numeroDeArgumentos)
            {
                case 0:
                    Console.WriteLine("Nenhum argumento");
                    break;
                case 1:
                    Console.WriteLine("Um argumento");
                    break;
                case 3:
                    Console.WriteLine("Três argumentos");
                    break;
                default:
                    Console.WriteLine($"{numeroDeArgumentos} argumentos");
                    break;
            }
        }
        static void InstrucaoWhile(string[] texto)
        {
            int i = 0;
            while (i < texto.Length)
            {
                Console.WriteLine(texto[i]);
                i++;
            }
        }
        static void InstrucaoDo()
        {
            string texto;
            do
            {
                Console.WriteLine("Digite um texto para continuar ou aperte ENTER para sair: ");
                texto = Console.ReadLine();
                Console.WriteLine(texto);
            } while (!string.IsNullOrEmpty(texto));
        }

        static void InstrucaoFor(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
        }

        static void InstrucaoForeach(string[] args)
        {
            foreach (string s in args)
            {
                Console.WriteLine(s);
            }
        }
        static void Main(string[] args)
        {
            string[] nome = {"João Lucas", "Joana", "Pedro"};
            //InstrucaoIf(nome);
            //InstrucaoSwitch(nome);
            InstrucaoDo();
        }
    }
}
