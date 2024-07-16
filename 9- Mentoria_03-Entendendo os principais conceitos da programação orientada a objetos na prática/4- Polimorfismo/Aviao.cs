using System;

namespace _4__Polimorfismo
{
    // classe Aviao herda classe Veiculo
    class Aviao : Veiculo
    {
        public int nDeTurbinas { get; set; }

        public Aviao (string marca, string modelo, string cor, int ndeturbinas)
        { 
            this._marca = marca;
            this._modelo = modelo;
            this._cor = cor;
            this.nDeTurbinas = ndeturbinas;
            Console.WriteLine("Eu sou um avião");
        }

        // Sobreescrevendo a maneira de ligar  do avião para não ser igual do carro com OVERRIDE
        public override void ligar()
        {
            Console.WriteLine("* Ligando avião");
        }
    }
}