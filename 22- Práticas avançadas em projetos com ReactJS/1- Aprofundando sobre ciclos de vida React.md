### OBJETIVOS DA AULA

1. Ciclo de Vida
2. Hooks
3. Context API

### CICLO DE VIDA REACT

* Inicialização
* Montagem
* Atualização
* Desmontagem

![](C:\Users\Admin\Desktop\DigitalOne\22- Práticas avançadas em projetos com ReactJS\PNGs\1-cicloDeVida.png)

![](C:\Users\Admin\Desktop\DigitalOne\22- Práticas avançadas em projetos com ReactJS\PNGs\2-cicloDeVidaTodos.png)



### EXEMPLO CICLO DE VIDA COMPONENTE

1- Criar o projeto no terminal

$ npx create-react-app advanced-reactjs-dio



Após, criamos a nosso arquivo Twitter.js contendo:

![](C:\Users\Admin\Desktop\DigitalOne\22- Práticas avançadas em projetos com ReactJS\PNGs\3-Twitter_JS.png)

shouldComponentUpdate retorna um booleano (verdadeiro ou falso)

### Agora criamos nosso arquivo App.js contendo as ações de Twitter

![](C:\Users\Admin\Desktop\DigitalOne\22- Práticas avançadas em projetos com ReactJS\PNGs\4- App_JS.png)



## HOOKS

### Introdução

"Hooks são uma nova adição ao React 16.8. Eles permitem que você use o state e outros recursos do React sem escrever uma classe."

Hooks são criados com 'function'

Quando for utilizar um hook, ele espera que passe uma função pra ele, e ele recebe como segundo argumento um array, do qual podemos passar vários atributos para esse array;

useEffect(() => {

}, [ ])

Esse array espera funções utilizadas dentro de useEffect ou parâmetros de quando ele vai atualizar, de quando ele vai cair novamente nesse ciclo de vida

### => shouldComponentUpdate com hooks

Precisamos importar alem do useEffect, o memo, com ele conseguimos criar componentes puros

$ import React, {  useEffect, memo	} from 'react';

E ele aceita como segundo elemento uma função:

$ export default memo(Twitter, areEqual);

### Podemos usar 'useState' com hooks também, basta importar

import $ import React, { useEffect, useState, memo	} from 'react';



### => Exemplo Hooks

1- Criamos o nosso projeto via terminal

$ npx create-react-app nomeProjeto



2- Criamos agora um arquivo Twitter.js contendo:

![](C:\Users\Admin\Desktop\DigitalOne\22- Práticas avançadas em projetos com ReactJS\PNGs\6-Twitter_Hooks.png)



3- Criar o arquivo App.js que defini os estados de nossos componentes

![](C:\Users\Admin\Desktop\DigitalOne\22- Práticas avançadas em projetos com ReactJS\PNGs\7- App_Hooks.png)



### Regras dos Hooks

Não use Hooks dentro de funções JavaScript comuns. Em vez disso, você pode:

* Chamar Hooks em componentes React;
* Chamar Hooks dentro de Hooks customizados

Seguindo essas regras, você garante que toda lógica de estado (state) no componente seja claramente visível no código fonte.



## Context API Com Hooks

* Ele tem o consumer e o provider dele

* 'Theme.js' Utilizado para passar valores entre componentes, sem ter que passar por um componente intermediário, comum pra login, tema, valores globais

* Porém o Theme.js não é suficiente para fazer uma chamada em qualquer parte, teremos que criar no App.js que é a camada principal do projeto;

* API provider e a que providencia os valores dali para baixo, qualquer componente que estiver entre a provider, poderá estar ouvindo, consumindo os valores iniciais desse contexto;

  

  ### EXEMPLO

  1- Cria o 'App.js' que será a base do projeto contendo:

  ![](C:\Users\Admin\Desktop\DigitalOne\22- Práticas avançadas em projetos com ReactJS\PNGs\8- App_Context.png)

​	

​	2- Criação Theme.js

![](C:\Users\Admin\Desktop\DigitalOne\22- Práticas avançadas em projetos com ReactJS\PNGs\9-Theme_ContextJs.png)



3- Criando e chamando useContext em formulário

![](C:\Users\Admin\Desktop\DigitalOne\22- Práticas avançadas em projetos com ReactJS\PNGs\10- Form_Context_JS.png)

4- Criando e chamando useContext 'Card.js'

![](C:\Users\Admin\Desktop\DigitalOne\22- Práticas avançadas em projetos com ReactJS\PNGs\11- Card_Context_JS.png)