using System;

namespace _2__Encapsulamento
{
    public class Veiculo : InterfaceVeiculo
    {
        // Atributos
        public string _marca { get; private set; }
        public string _modelo { get; set; }
        public string _cor { get; set; }
        public string _combustivel { get; set; }

        // Métodos
        public Veiculo () // método construtor vazio
        {

        }
        public Veiculo (string marca, string modelo, string cor, string combustivel) // Método construtor
        {
            this._marca = marca;
            this._modelo = modelo;
            this._cor = cor;
            this._combustivel = combustivel;
        }
        /*
        Daqui abaixo, pensaremos nos outros métodos, nas ações do objeto veículo;
        O que um veículo faz?
        Um véiculo liga, desliga, acelera, freia etc, então agora descreveremos isso.
        */
        public void ligar()
        {
            Console.WriteLine($"O veículo {this._marca} {this._modelo} está ligado");
            processoLigar();
        }
        
        public void acelerar()
        {
            Console.WriteLine($"O veículo {this._marca} {this._modelo} acelerou");
        }

        public void frear() {
            Console.WriteLine($"O veículo {this._marca} {this._modelo} freou");
        }

        public void desligar()
        {
            Console.WriteLine($"O veículo {this._marca} {this._modelo} desligou");

        }
        /*
        Agora vamos as implementações das ações do veículo
        Como um veiculo liga?
        */
        public void processoLigar()
        {
            Console.WriteLine($"    - Colocar a chave na ignição");
            Console.WriteLine($"    - virar a chave");
        }
    }
}