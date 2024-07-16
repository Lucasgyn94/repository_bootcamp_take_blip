## OBJETIVOS DA AULA



### 1. Aprender sobre a história e aplicação do Typescript

### 2. Entender sobre linguagem transpilada e sua utilização

### 3. Aprender a utilizar typescript em um projeto real



## Requisitos Básicos

* Programação orientada a objetos
* Conhencimento básico em JavaScript



## Parte 1: História do Typescript

* Proveniente da evolução em relação ao uso de JavaScript;
* Criada pela Microsoft em 2012;
* Projeto de código aberto;
* Lançada em 2014 junto com o suporte para a linguagem no Visual Studio 2013



### Qual problema o TS resolve?

"A POO sempre foi um problema ao ser aplicado e JavaScript, devido a sua sintaxe não permiti escrever classes, por exemplo, de forma tão clara, além da fraca tipagem de dados. O TypeScript fornece então uma forma de corrigir ou contornar esses problemas" - Devmedia



### Conceitos do Typescript

* Tipagem estática opcional;
* Implementação de conceitos de POO;
* Possibilidade de validação de erros pré-compilação (ou pré-traspilação)
* Utiliza o compilador Babel para transformar o código em JavaScript;
* Integra completamente com a ECMAScript;

* O typescript e um superset do javascript;
* Um superset é um conjunto de práticas, soluções pré-estabelicidas que acopla no javascript, ou nesse caso hoje em dia no Ecmascript, que é a conversão que mantém o javascript hoje



### Compilar vs Transpilar

**Compilar** é o termo geral para pegar o código-fonte escrito em uma linguagem e transformá-lo em outra.

**Transpilar** é um termo específico para pegar o código-fonte escrito em uma linguagem e transformá-lo em outra linguagem que tenha um nível de abstração semelhante.



### Quando usar Typescript?

Quando você estiver algumas dessas necessidades no seu projeto:

* Padronização

* Escalabilidade

  Geralmente, o nosso projeto começa muito pequeno, escalabilidade se diz respeito a expandir o sistema exponencialmente, atendendo todas as necessidades do usuário;

* Utilização constante de tipos avançados;

  Tuplas, Genérico, são tipos mais avançados que utilizamos com javascript;

* Necessidade de utilização de conceitos de POO.



### TIPAGEM

=> Tipos

* String
* Boolean
* Number
* Array
* Tuple
* Enum
* Any
* Void
* Unknown
* Never
* Function (callback)



### POO

Relembrando os conceitos iniciais de POO:

* Encapsulamento

  E quando temos uma váriavel, que escolhemos como ele vai ser retornada, e como ela vai ser gravada, então fazemos um get e um set

* Herança

  E quando temos uma classe que herda características de outra classe

* Abstração

  E podermos definirmos que toda classe que implementa aquela abstração, ela siga um padrão/ contrato específico de execução

* Polimorfismo

OBS: As técnicas do POO possibilitam a 

$

interface IVeiculo {

​	private _chassi: string;

​	get Chassi(): string {

​			return this._chassi;

​	}



​	constructor(chassi: string) {

​		this._chassi = chassi;

​	}

}



### EXEMPLO

### 1- Encapsulamento / Herança

![](C:\Users\Admin\Desktop\DigitalOne\24- Mentoria 06 Typescript - Início prático\PNGs\1-EncapsulamentoHeranca.png)



extends = extende

implements = implementa



### 2- Abstração/Polimorfismo

![](C:\Users\Admin\Desktop\DigitalOne\24- Mentoria 06 Typescript - Início prático\PNGs\2-AbstracaoPolimorfismo.png)



### Exemplo avançado Typescript

![](C:\Users\Admin\Desktop\DigitalOne\24- Mentoria 06 Typescript - Início prático\PNGs\3-ExemploAvancadoTypescript.png)

catch = pegar

throm = lançar

@ = decorator

O método **map()** invoca a função `callback` passada por argumento para cada elemento do Array e devolve um novo Array como resultado.

