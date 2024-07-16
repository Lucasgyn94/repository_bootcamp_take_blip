##### # React

#### Meu primeiro componente

=> Primeiro, criaremos nosso projeto chamado react-dio do app em react  

$ npx create-react-app react-dio



=> O react é um framework baseado em javascript que permite agente modularizar uma aplicação. Ou seja, quando temos hoje uma página na internet temos la o componente do menu, um carrocel com informações, uma lista de notícias, todos esses itens, são módulos;



=> Render

render() é um metodo do objeto ReactDOM; 

Esse método recebe dois parametros



OBS:

Para trabalhar com componentes irmão temos que colocar dentro de uma div ou de uma <></> sem passar nada mesmo, em vazio



=> Trabalhando com o bootstrap, na documentação 5.0

* Copiar e colar a folha de estilo <link> no <head> antes de todas as outras folhas de estilo para carregar o CSS.

  $ <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">

=> Se quisermos deixar a nossa aplicação mais personalizada, precisamos também do Bundle do bootstrap 5, o mesmo e colado antes do fechamento do </body>, ele inclue todos os plugins e dependências do Bootstrap Javascript;

$ <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>



=> Agora vamos pegar no bootstrap as opções de grupos de listas, na pasta 'list group / list group' da documentation, abreviação de acesso 'list'

=> Vamos adicionar a lista que faz um item ficar um pouco colorido. Colocaremos o arquivo dentro de uma <li> que esta contida dentro de uma <ul> abaixo do <h1> no nosso arquivo App.js

$ <a href="#" class="list-group-item list-group-item-action list-group-item-dark">A simple dark list group item</a>

* Lembrando que onde for class, devemos substituir por className

=> Agora vamos criar a nossa pasta "components" e dentro dela a pasta item, que vai receber o nosso index.js, nele colocaremos o nosso script do componente botão do App.js para não ficar havendo rendundância de código

* props são propriedades

* Adicionar (class='container') dentro da tag inicial body <body class='container'> faz com que de uma centralizada mais ao centro;



=> Agora, dentro da pasta components, iremos criar uma pasta chamada Card e dentro terá um arquivo index.js;



=> Apos, na documentação do bootstrap, iremos procurar 'Cards/Cards', colocando no campo de pesquisa 'card'; 

No exemplo usaremos o card 'Header and footer'



=> Após na documentação do bootstrap iremos procurar por Buttons, e pegaremos no Examples o button de 'Success' e o de 'Danger'



State?

O useState traz uma variavel e uma função

O que o useState faz? Ele declara um variável state. Nossa variável é chamada de count mas poderíamos chamar de qualquer coisa, como banana. Esta é uma maneira de “preservar” alguns valores entre as chamadas de funções — useState é uma nova maneira de usar as mesmas capacidades que o this.state tem em uma classe. Normalmente, variáveis “desaparecem” quando a função sai mas variáveis de state são preservadas pelo React.

  Sintaxe:

  import React, { useState } from 'react';

  function Example() {

  // Declarar uma nova variável de state, na qual chamaremos de "count"

  const [count, setCount] = useState(0);





OBS: tags <></> possuem propriedades próprias

OBS2: children é uma propriedade especial dos componentes React que contém elementos filhos a serem definidos no componente