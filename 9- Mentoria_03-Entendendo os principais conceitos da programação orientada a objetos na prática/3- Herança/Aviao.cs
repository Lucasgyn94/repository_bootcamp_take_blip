using System;

namespace _3__Herança
{
    public class Aviao : Veiculo
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
        
    }
}