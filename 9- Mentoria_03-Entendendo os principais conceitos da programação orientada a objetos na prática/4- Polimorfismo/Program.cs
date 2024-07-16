using System;
using System.Collections.Generic; // Biblioteca para criar Lista de veiculos usando List<>

namespace _4__Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo carro = new Carro("Ford", "Mustang", "Ammarelo", 4);
            Veiculo aviao = new Aviao("Airbus", "A320", "Branca", 6);

            List<Veiculo> lista = new List<Veiculo>();
            lista.Add(carro);
            lista.Add(aviao);

            Console.Write("\n");
            carro.ligar();
            carro.acelerar();
            carro.frear();
            carro.desligar();
            
            Console.Write("\n");

            aviao.ligar();
            aviao.acelerar();
            aviao.frear();
            aviao.desligar();
            Console.Write("\n");
        }
    }
}
