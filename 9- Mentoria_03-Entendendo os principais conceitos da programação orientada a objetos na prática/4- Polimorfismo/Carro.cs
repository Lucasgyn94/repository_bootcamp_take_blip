using System;

namespace _4__Polimorfismo
{
    // classe Carro herda Veiculo
    class Carro : Veiculo
    {
        public int nDePortas { get; set; }
        public Carro(string marca, string modelo, string cor, int ndeportas) 
        {
            this._marca = marca;
            this._modelo = modelo;
            this._cor = cor;
            this.nDePortas = ndeportas;

            Console.WriteLine("Eu sou um carro");
        }
        
    }
}