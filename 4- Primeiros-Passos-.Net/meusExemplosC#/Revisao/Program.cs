using System;

namespace Revisao
{
    class Program
    {
        public static void Main(string[] args)
        {
            string opcaoMenu = "";
            Aluno[] alunos = new Aluno[5];
            var i = 0;

            while (opcaoMenu.ToUpper() != "X")
            {
                opcaoMenu = ObterOpcaoMenu();

                switch (opcaoMenu)
                {
                    case "1":
                        Console.WriteLine("\nDigite o nome do aluno");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Digite a nota do aluno");

                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("\nDigite um valor decimal");
                        }
                        alunos[i] = aluno;
                        i++;
                        break;

                    case "2":
                        foreach (var a in alunos)
                        {
                            if (!string.IsNullOrEmpty(a.Nome))
                            {
                                Console.WriteLine($"\nALUNO: {a.Nome} \t NOTA: {a.Nota}");
                            }
                        }
                        break;

                    case "3":
                        decimal notaTotal = 0;
                        var nroAlunos = 0;

                        for (i = 0; i < alunos.Length; i++)
                        {
                            if (!string.IsNullOrEmpty(alunos[i].Nome))
                            {
                                notaTotal = notaTotal + alunos[i].Nota;
                                nroAlunos++;
                            }
                        }
                        var mediaGeral = notaTotal / nroAlunos;

                        Conceito conceitoGeral;

                        if (mediaGeral <= 2)
                        {
                            conceitoGeral = Conceito.E;
                        }
                        else if (mediaGeral <= 4)
                        {
                            conceitoGeral = Conceito.D;
                        }
                        else if (mediaGeral <= 6)
                        {
                            conceitoGeral = Conceito.C;
                        }
                        else if (mediaGeral <= 8)
                        {
                            conceitoGeral = Conceito.B;
                        }
                        else
                        {
                            conceitoGeral = Conceito.A;
                        }

                        Console.WriteLine($"MÉDIA GERAL: {mediaGeral} - CONCEITO: {conceitoGeral}");
                        break;

                    default: throw new ArgumentOutOfRangeException("Escolha entre uma das opções do menu");
                }
                opcaoMenu = ObterOpcaoMenu();
            }
        }

        private static string ObterOpcaoMenu()
        {
            string opcaoMenu;
            Console.WriteLine("\n### MENU DE OPÇÕES ###");
            Console.WriteLine("1- Incluir aluno");
            Console.WriteLine("2- Listar nome e nota alunos");
            Console.WriteLine("3-AI Exibir média geral");
            Console.WriteLine("X- SR");
            Console.WriteLine("\nDigite a sua opção");
            opcaoMenu = Console.ReadLine();
            return opcaoMenu;
        }
    }
}
