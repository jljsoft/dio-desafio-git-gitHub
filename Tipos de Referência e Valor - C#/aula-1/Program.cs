using System;
using System.Collections.Generic;
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
        // ---------------------------------------------
        // ---------------------------------------------
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
        //----------------------------------------------
        //----------------------------------------------
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
        //----------------------------------------------
        //----------------------------------------------
        static void MudarParaImpar(int[] pares)
        {
            for (int i = 0; i < pares.Length; i++)
            {
                pares[i] = pares[i] + 1;
            }
        }
        static void Demo5()
        {
            
           int[] pares = new int[]{0, 2, 4, 6, 8};

           MudarParaImpar(pares);

           WriteLine($"Os numeros impares são: {string.Join(",", pares)}");
        }
        //----------------------------------------------
        //----------------------------------------------
        static int EncontrarNumero(int[] numeros, int numero)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                if(numeros[i] == numero)
                return i;
            }
            return -1;
        }
        static void Demo6()
        {
            
           int[] numeros = new int[]{0, 2, 4, 6, 8};
           WriteLine("Digite o numero que gostaria de encontrar:");
           var numero = int.Parse(ReadLine());
           var idxEncontrado = EncontrarNumero(numeros,numero);

           if(idxEncontrado >= 0)
           {
              WriteLine($"O número digitado está na posição {idxEncontrado}");
           }
           else
           {
              WriteLine("O número digitado não foi encontrado");
           }
        }
        //----------------------------------------------
        //----------------------------------------------
        static bool EncontrarPessoa(List<Pessoa> pessoas, Pessoa pessoa)
        {
            foreach (var item in pessoas)
            {
                //Para reference types, a comparação ocorre entre as referencias, o endereço na memoria.
                //Esta e a forma correta, especificando que a comparação e entre valores
                if(item.Nome == pessoa.Nome)
                {
                return true;
                }
            }
            return false;
        }
        static void Demo7()
        {
            List<Pessoa> pessoas = new List<Pessoa>()
            {
            new Pessoa(){Nome = "Ricardo"},
            new Pessoa(){Nome = "José"},
            new Pessoa(){Nome = "Maria"},
            new Pessoa(){Nome = "Fabiana"},
            new Pessoa(){Nome = "Eduardo"},
            };

            WriteLine("Digite a pessoa que gostaria de localizar:");
            var nome = ReadLine();
            var pessoa = new Pessoa(){Nome = nome};
            var encontrado = EncontrarPessoa(pessoas, pessoa);
            if(encontrado)
            {
                WriteLine("Pessoa localizada!");
            }
            else
            {
                WriteLine("Pessoa não localizada");
            }
        }
        //----------------------------------------------
        //----------------------------------------------
        static bool EncontrarPessoa(List<StructPessoa> pessoas, StructPessoa pessoa)
        {
            foreach (var item in pessoas)
            {
                if(item.Equals(pessoa))
                {
                return true;
                }
            }
            return false;
        }
       public static void Main()
       {
            List<StructPessoa> pessoas = new List<StructPessoa>()
            {
            new StructPessoa(){Nome = "João Lucas"},
            new StructPessoa(){Nome = "José"},
            new StructPessoa(){Nome = "Iara"},
            new StructPessoa(){Nome = "Fabiana"},
            new StructPessoa(){Nome = "Eduarda"},
            };

            WriteLine("Digite a pessoa que gostaria de localizar:");
            var nome = ReadLine();
            var pessoa = new StructPessoa(){Nome = nome};
            var encontrado = EncontrarPessoa(pessoas, pessoa);
            if(encontrado)
            {
                WriteLine("Pessoa localizada!");
            }
            else
            {
                WriteLine("Pessoa não localizada");
            }

       }
    }
}
