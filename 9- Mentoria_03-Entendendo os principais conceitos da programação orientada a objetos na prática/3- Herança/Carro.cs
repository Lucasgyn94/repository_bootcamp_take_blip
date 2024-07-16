using System;

namespace _3__Herança
{
    public class Carro : Veiculo
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

/*
METODO CONSTRUTOR 2 FORMA HERDANDO BASE(MARCA, MODELO, COR)
public Carro(string marca, string modelo, string cor)
: base(marca, modelo, cor) // Significa que da classe base estou passando a marca, modelo e cor
{

}
*/