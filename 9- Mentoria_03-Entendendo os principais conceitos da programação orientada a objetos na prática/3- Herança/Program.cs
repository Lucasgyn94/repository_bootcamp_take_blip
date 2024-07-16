using System;

namespace _3__Herança
{
    class Program
    {
        static void Main(string[] args)
        {

            Veiculo carro = new Carro("Ford", "Mustang", "Ammarelo", 4);
            Veiculo aviao = new Aviao("Airbus", "A320", "Branca", 6);

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
