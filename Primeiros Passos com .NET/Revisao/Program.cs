using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];

            int indice = 0;
            string opcaoUsuario = MenuOpcoesUsuario();

            while (opcaoUsuario.ToUpper() != "S")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        //TODO: inserir aluno
                        Console.WriteLine("Informe o nome do aluno:");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Informe a nota do aluno:");
                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        }
                        else 
                        {
                            throw new ArgumentException("Valor precisa ser decimal");
                        }

                            alunos[indice] = aluno;
                            indice++;

                        break;
                    case "2":
                        //TODO: listar alunos
                        foreach (var alunoItem in alunos)
                        {
                            if (!string.IsNullOrEmpty(alunoItem.Nome))
                            {
                                Console.WriteLine($"ALUNO: {alunoItem.Nome} --- NOTA: {alunoItem.Nota}");
                            }
                        }

                        break;
                    case "3":
                        //TODO: calcular media
                        decimal notaTotal = 0;
                        var nrAlunos = 0;

                        for (int i = 0; i < alunos.Length; i++)
                        {
                            if (!string.IsNullOrEmpty(alunos[i].Nome))
                            {
                                notaTotal = notaTotal + alunos[i].Nota;
                                nrAlunos ++;
                            }
                        }

                        var mediaGeral = notaTotal / nrAlunos;
                        Conceito conceitoGeral;

                        if (mediaGeral < 2)
                        {
                            conceitoGeral = Conceito.E;
                        }
                        else if (mediaGeral < 4)
                        {
                            conceitoGeral = Conceito.D;
                        }
                        else if (mediaGeral < 6)
                        {
                            conceitoGeral = Conceito.C;
                        }
                        else if (mediaGeral < 8)
                        {
                            conceitoGeral = Conceito.B;
                        }
                        else
                        { 
                            conceitoGeral = Conceito.A;
                        }
                        Console.WriteLine($"MEDIA GERAL: {mediaGeral} --- CONCEITO: {conceitoGeral}");

                        break;
                    default:
                        //Valor informado esta fora do range de opcoes
                        throw new ArgumentOutOfRangeException();

                }

                opcaoUsuario = MenuOpcoesUsuario();
            }

        }

        private static string MenuOpcoesUsuario()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine(" -- 1 - Inserir Aluno ---");
            Console.WriteLine(" -- 2 - Listar Alunos ---");
            Console.WriteLine(" -- 3 - Calcular Meida---");
            Console.WriteLine(" -- S -       Sair    ---");
            Console.WriteLine("-------------------------");

            string opcaoUsuario = Console.ReadLine();
            return opcaoUsuario;
           

        }
    }
}
