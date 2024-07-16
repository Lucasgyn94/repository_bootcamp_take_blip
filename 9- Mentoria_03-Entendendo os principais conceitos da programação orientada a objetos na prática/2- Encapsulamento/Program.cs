using System;

namespace _2__Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo carro1 = new Veiculo("Wolkswagen", "Jetta", "Preto", "Flex");
            Veiculo carro2 = new Veiculo("Ford", "Mustang", "Amarelo", "Gasolina");

            Console.Write("\n");
            carro1.ligar();
            carro1.acelerar();
            carro1.frear();
            carro1.desligar();
            
            Console.Write("\n");

            carro2.ligar();
            carro2.acelerar();
            carro1.frear();
            carro1.desligar();
            Console.Write("\n");
        }
    }
}
