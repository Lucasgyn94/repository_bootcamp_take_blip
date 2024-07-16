Objetivos da Aulda

1. Introdução ao Flux
2. O que é Redux
3. Exemplo Redux + React

Requisitos básicos

1. Ter feito a Aula 1
2. Editor de Texto
3. Ter o Node.js e React corretamente instalados
4. Instalar o Redux Dev Tools no Chrome



## FLUX

Flux é uma arquitetura criada pelo facebook para comunicação entre componentes

Flux é um padrão de projeto para tráfego de dados de maneira unidirecional.

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\Flux.png)



### => Action

Action: é como um telégrafo: ele formata a mensagem a ser enviada

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\FluxAction.png)



### => Dispatcher

Dispatcher: é como um telefonista; ele sabe todos os callbacks para diferentes Stores;

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\FluxDispatcher.png)

Dispatcher = Dispachante



### => Store

Store: é como um gerente super controlador; Ele guarda a informação e todas as alterações têm que ser feitas por ele mesmo mais ninguém;

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\FluxStore.png)



### => View

View: é como um gerente intermediário (middleware) que recebe as notificações da store e passa os dados para as visões abaixo dela.

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\FluxView.png)



=> A arquitetura fluxa tem diversas implementações

* Redux (mais popular);
* Reflux
* Mobx
* Vuex (baseado em Redux e Elm)
* NgRx/store (baseada em Redux e RxJS)

=> Bibliotecas baseadas em Flux

* Servem para comunicação entre componente
* Centralizam a informação
* "Flux libraries are like glasses: you'll know when you need them." As bibliotecas de flux são como óculos: você vai saber quando usar ela



## REDUX

* Criado por Dan Abramov e Andrew Clark em 2015
* Redux é uma implementação de Flux
  * Possui algumas diferenças



### Esquema Funcionamento Redux

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\EsquemaFuncionamentoRedux.png)

### => Redux tem 3 princípios básicos

1. Single source of truth: Uma única store
2. State é read-only
3. Mudanças são feitas com pure functions

### Actions

Em Redux, 

* Actions são como o Flux
* Diferença: Action não enviam a action em si para o dispatcher
* Retornam um objeto de action formatado



### Store

Em flux: diversas Stores

Em Redux: uma única Store

A store aqui cuida de toda a árvore de estados

Os reducers (redutores) que cuidam de descobrir qual estado muda



### Reducers

* Em Redux não dispatcher (simplica e divide o trabalho da Store)
* A Store se conecta ao root reducer, que divide os estados em pequenos reducers para descobrir como lidar com esse estado.
* Os estados são imutáveis



### Views

Em React, adiciona na camada de View 3 novos conceitos para conectar a View à Store:

1. Provider

   E um rapper da árvore de componentes, a responsabilidade dele e tornas mais fácil para os componentes filhos se conectar a Store utilizando connect

   

2. connect( )

   É uma função do React Redux, e se algum componente deseja pegar algum update do estado por exemplo, ele se envolve na função connect;

   

3. selector

   Selector é uma função que agente mesmo escreve que define os estados do Redux que agente quer passar como props.



## Redux + React: Abordagem Prática

Primeira coisa, instalar os pacotes para o Redux funcionar

$ npm install react-redux

$ npm install --save-dev redux-devtools

O devtools e o monitor, que serve pra gente monitorar as alterações de estado da nossa Store

Pela Chrome Web Store instalaremos o 'Redux DevTools' oferecido por remotedevio



Primeira coisa e criar uma pasta Redux, e nessa pasta Redux teremos um arquivo action.js contendo nossas ações, actions são mensangens a ser enviada para nossa aplicação, no nosso exemplo as actions são incrementar e decrementar:

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\conterActionRedux.png)

$

export const INCREMENT = 'INCREMENT'

export cont DECREMENT = 'DECREMENT'



### Criada as Actions, agora vamos criar alguns reducers (redutores)

=> Na pasta redux, criaremos o arquivo reducers.js que contém o seguinte código:



![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\Reducer.png)



=> Agora criaremos o nosso componente do reducers chamado Counter.jsx e dentro dele o código:

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\ReducerComponent.png)

o connect pega o matStateProps e conecta o componente com a nossa Store;

