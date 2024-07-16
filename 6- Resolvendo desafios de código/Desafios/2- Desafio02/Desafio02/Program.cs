using System;

namespace Desafio02
{
/*
Leia 2 valores de ponto flutuante de dupla precisão A e B, que correspondem a 2 notas de um aluno. 
A seguir, calcule a média do aluno, sabendo que a nota A tem peso 3.5 e a nota B tem peso 7.5 
(A soma dos pesos portanto é 11). Assuma que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.
*/
    class Program
    {
        static void Main(string[] args)
        {
            double notaA, notaB, mediaP;

            notaA = Double.Parse(Console.ReadLine());
            notaB = Double.Parse(Console.ReadLine());
            mediaP = ((notaA * 3.5) + (notaB * 7.5)) / 11;

            Console.WriteLine("MEDIA DO ALUNO = " + mediaP.ToString("0.00000"));


        }
    }
}
