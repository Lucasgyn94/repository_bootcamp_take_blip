## COMUNICAÇÃO AVANÇADA ENTRE APLICAÇÕES

=> Objetivos da Aula

1. Rest HTTP com React
2. Imutabilidade e Redux
3. Redux + Rest

=> Requisitos Básicos

1. Ter feito as aulas 1 e 2
2. Editor de Texto
3. Ter o Node.js e React corretamente instalados
4. Instalar o Redux Dev Tools no Chrome



## PARTE 1: Rest HTTP com React



### => APIS HTTP

Servem para conectar a um ou mais servidores HTTP em uma aplicação, os principais métodos são:

* GET

  Para listagem de dados

* POST

  Para criação de dados

* DELETE

  Para deleção de dados

* PUT / PATH

  Para alteração de dados

E existem duas abordagens

1. Fetch Api

2. Axios



### => Fetch Api

* Nativa do browser
* Ofrerece uma alternativa ao XMLHttpRequest() e jQuery.ajax()
* Suporte a Service Workers
* Algumas diferençãs
  * Não envia nem recebe cookies (precisa definir a opção credentials)
  * Não rejeita o status do erro HTTP



### EXEMPLO BIBLIOTECA CIENTISTA-BRASILEIRA FAZENDO UM GET COM FETCH API

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\FetchApi.png)

### CADASTRAR UMA NOVA CIENTISTA COM POST NA API

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\PostApi.png)



### DELETAR CIENTISTA DA API

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\DeleteAPI.png)



### ALTERAR ALGUM DADO DA API COM PUT

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\PutAPI.png)



### => AXIOS BIBLIOTECA

* Lib de HTTP API
* Cross-browser
* Pode monitorar o progresso de um request
* Melhor tratamento de erros 
* Melhor teste



=> Para utilizar o Axios, e necessário instalar com yarn via terminal

$ yarn add axios



### EXEMPLO DA REQUISIÇÃO GET API COM AXIOS

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\GetAxios.png)



### EXEMPLO DA REQUISIÇÃO GET POST COM AXIOS

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\PostAxios.png)



### EXEMPLO DA REQUISIÇÃO PUT COM AXIOS

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\PutAxios.png)



### EXEMPLO DA REQUISIÇÃO DELETE COM AXIOS

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\DeleteAxios.png)





## PARTE 2: IMUTABILIDADE E REDUX

### Imutabilidade

* Uma vez criada, uma coleção não pode ser alterada.
* Novas coleções podem ser criadas a partir de uma coleção anterior e uma mutação (setter) como um conjunto.
* Novas coleções são criadas usando o máximo possível da estrutura original, reduzindo a cópia e aumentando a perfomance



=> Benefícios

* Perfomance
* Programação mais simples por estar trabalhando com estruturas fixas
* Debugging mais simples (detecção de mudanças)



=> Relação Imutabilidade e React

* Se você quer perfomance em React, use dados imutáveis.
* Você consegue usando o shouldComponentUpdate ou React.PureComponent.

### Exemplo Código com shouldComponentUpdate()

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\shouldComponentUpdate.png)



### Grafo de Renderização de Componentes

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\Grafo.png)



### EXEMPLO CODIGO ANTERIOR USANDO PURE COMPONENT

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\PureComponent.png)

* Porém nem todos casos dão certo de ser controlados com PureComponent, vejamos um caso a seguir em que isso da um problema:

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\PureComponentErro.png)

### => Problema

* O PureComponent vai fazer uma comparação rasa entre os valores antigos e novos de this.props.words;
* O código muda words no handleClick do WorkAdder mas, mesmo mudando as palavras serão consideradas como iguais.

### => Solução 1

Fazendo uma estrutura imutável

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\solucao1.png)

### Solução 2

Usando biblioteca de imutabilidade

Um exemplo e a 'Immutable.js'

=> Immutable.js

* Biblioteca que fornece coleções persistentes e imutáveis.
* Permite detecção barata de alteração nos projetos.

### EXEMPLO

Considere esse pequeno trecho de código mutável:

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\trecho.png)

Para resolver esse problema com immutable.js fica:

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\foo.png)



=> Outras libs:

* Immer
* Immutability-helper
* Seamless-immutable



### => Imutabilidade e Redux

Imutabilidade é pré requisitto no Redux

* Redux e React-Redux utilizam comparações rasas
* Manipulação de dados mais segura
* Time-Travel debugging



=> Como ele Faz Isso?

* Os reducers dividem o objeto de estados em domínios por uma chave;
* CombineReducers checa mudança usando compração rasa
  1. Fazem a interação nos reducers
  2. Criam um novo objeto de estados a partir dos estados retornados por cada reducer

* connect gera componentes que fazem compração rasa com o estado root
* Retornam o valor para a função mapStateToProps, verificando aqueles que precisam de uma operação de re-render.

=> PORQUE NÃO FUNCIONA COM OBJETOS MUTÁVEIS?

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\Imutabilidade.png)



## Redux + Rest

* Suponha um sistema de notificação ou um sistema de logging;
* Você precisa manter a sincronia, independente da tela onde estiver
* Uma maneira de resolver fácil seria armazenar os dados do serviço no Redux
* Para fazer isso precisamos de uma camada a mais, que são os Middlewares

### Redux Middlewares

* Provê uma camada entre o disparo de uma ação e o momento que ela atinge o reducer.
* Utilizados para uma variedade funções, entre elas chamadas de APIs de serviço
* 

### Entendendo os Middlewares

* Imagine um sistema de log, onde toda action disparada em um sistema é impressa com o log na tela

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\Middlewares.png)



### Tentativa de resolução 1

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\logginManual.png)

Esse trecho de código funciona, porém tem que repetir sempre que precisar, causando uma certa poluição no código

### Tentativa de resolução 2

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\dispatch.png)



### Tentativa de Resolução 3

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\SubDispatch.png)



=> Essa tentativa e boa, mas e se eu quisesse fazer outra coisa, como um crash report usando a mesma estrutura?

![]()![PatchStore](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\PatchStore.png)

Isso funciona, porém ainda não está legal

### Tentativa de Resolução 4

Escondendo a gambiarra

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\EscondendoGambiarra.png)



### Tentativa de Resolução 5

Removendo a gambiarra

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\RemoveGambiarra.png)



=> Iremos fazer um currying dessa função ficando da seguinte forma:

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\Currying.png)

Porem ainda não está legal



### Tentativa de Resolução 6: Aplicando o middleware na mão:

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\applyMiddleware.png)

### Diferenças dela para a apply do redux:

* 3 diferenças do applyMiddleware() do Redux:
  * Só expõe um subconjunto da Store API para o middleware: dispatch e getState()
  * Fica difícil saber se store.dispatch(action) vai realmente percorrer a cadeia do middleware de novo.
  * Opera em cima de createStore() ao invés da store em si.

### Abordagem Final

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\abordagemfinal.png)

E finalmente

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\AbordagemFinal2.png)



### Middlewares não manuais

Os mais usados são:

* redux-thunk
* redux-saga



### => Iremos pegar um exemplo utilizando redux-thunk

=> Redux Thunk

Um thunk vem de pensar, 'pensei'

* Um thunk é uma função que chama outra função

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\ReduxThunk.png)

* O Redux Thunk e uma biblioteca, e instalamos utilizando:

  yarn add redux-thunk

### EXEMPLO REDUX

Iremos chamar a api de cientistas brasileiras para dentro do Redux.

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\CreateStore.png)



Agora criamos a nossa rootReducer.js



![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\rootReducer.png)



​	Criamos nossa actions

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\reducerfetch.png)



Apartir dessas actions acima, definimos um reducer para elas:

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\cientistaReducer.png)



Apos, criaremos nosso arquivo de fetch onde fazemos os dispatch a partir de um fetch api no Topico1 dessa aula

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\fetchdispatch.png)

E por fim o Topico3.jsx define a forma final de conectar essa aplicação no Redux

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\Topico3.png)

