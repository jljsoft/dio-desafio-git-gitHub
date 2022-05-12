using System;
using static System.Console;

namespace aula_1
{
    class Program
    {
        static int Adicionar20(int y)
        {
            return y + 20;
        }
       public static void Main()
       {
            int a = 2;
           a = Adicionar20(a);

            WriteLine($"O Valor da variável a é {a}");
       }
    }
}
