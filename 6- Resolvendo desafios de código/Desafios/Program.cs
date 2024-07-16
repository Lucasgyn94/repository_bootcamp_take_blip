using System;

// Leia quatro valores inteiros A, B, C e D. 
//A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D 
// segundo a fórmula: DIFERENCA = (A * B - C * D).
namespace Desafios
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            var diferenca = 0;

            Console.WriteLine("Digite o primeiro valor: ");
            a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro valor: ");
            b = Int32.Parse(Console.ReadLine());
    
            Console.WriteLine("Digite o primeiro valor: ");
            c = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro valor: ");
            d = Int32.Parse(Console.ReadLine());

            diferenca = (a * b - c * d);

            Console.WriteLine("DIFERENCA = " + diferenca);
        }
    }
}
