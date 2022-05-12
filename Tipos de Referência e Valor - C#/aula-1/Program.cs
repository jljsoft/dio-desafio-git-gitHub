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
        static void Demo1(){
            int a = 2;
           a = Adicionar20(a);

            WriteLine($"O Valor da variável a é {a}");
        }
        // -------------------------------------------
        // -------------------------------------------
        static void TrocarNome(Pessoa p1, string novoNome)
        {
            p1.Nome = novoNome;
        }
        static void Demo2(){
            
            Pessoa p1 = new Pessoa();
            p1.Nome = "João Lucas";
            p1.Idade = 23;
            p1.Documento = "123456";

            //p2 recebe uma referencia para a mesma instancia de p1 na heap
            //Pessoa p2 = p1;
            //Neste momento p2 aponta para uma nova instância na heap.
            Pessoa p2 = p1.Clone();


            TrocarNome(p1, "Pedro");

            WriteLine($@"
            O nome de p1 é: {p1.Nome}
            O nome de p2 é: {p2.Nome} 
            ");
        }
        //---------------------------------------------
        //---------------------------------------------
        static StructPessoa TrocarNome(StructPessoa p1, string nomeNovo)
        {
            p1.Nome = nomeNovo;
            return p1;
        }
        static void Demo3()
        {
              
            StructPessoa p1 = new StructPessoa
            {
            Documento = "123456",
            Idade = 23,
            Nome = "João Lucas"
            };

            var p2 = p1;

            p1 = TrocarNome(p1, "Pedro");

            WriteLine($@"
            Nome do p1 {p1.Nome}
            Nome do p2 {p2.Nome}
            ");
        }
        //----------------------------------------------
        //----------------------------------------------
        static string TrocarNome(string nome, string nomeNovo)
        {
            nome = nomeNovo;
            return nome;
        }
        static void Demo4()
        {
           string nome = "João Lucas";

           nome = TrocarNome(nome, "Thiago");

           WriteLine($"O novo nome é:{nome}");
        }
       public static void Main()
       {
           Demo4();
       }
    }
}
