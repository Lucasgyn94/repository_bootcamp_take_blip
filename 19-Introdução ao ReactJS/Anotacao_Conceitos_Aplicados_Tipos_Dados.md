Objetivos da Aula

1. [Renderização Condicional]
2. [Listas e Chaves]
3. [Manipulação de Eventos]

=> Renderização Codicional

"Em React, você pode criar componentes distintos que encapsulam o comportamento que você precisa. Então, você pode renderizar apenas alguns dos elementos, dependendo do estado da sua aplicação."

Existem 4 tópicos relevantes

* Variáveis de Elementos
* If inline com o Operador Logio &&
* If-Else inline com Operador Condicional
* Evitando que um Componente seja Renderizado



2. LISTA E CHAVES

* Renderizando Múltiplos Componentes
* Componentes de Lista Básico
* Chaves
* Extraindo Componentes com chaves
* Chaves devem ser Únicas apenas entre Elementos Irmãos



key faz o id ficar unico

3. MANIPULANDO EVENTOS

   Manipular eventos em elementos React é muito semelhante a manipular eventos em elementos do DOM. Existem algumas diferenças sintáticas:

   * Eventos em React são nomeados usando camelCase ao invés de letras minúsculas.
   * Com o JSX você passa uma função como manipulador de eventos ao invés de um texto;

   

   Os **eventos são** basicamente um conjunto de ações que **são** realizadas em um determinado elemento da página web, seja ele um texto, uma imagem, ou uma div, por exemplo.

   

   => Event.target

   É Uma referência ao objeto que enviou o evento.

   * Sintaxe
     - theTarget = e.target

   

   A propriedade `**onclick**` do mixin [`GlobalEventHandlers`](https://developer.mozilla.org/pt-BR/docs/Web/API/GlobalEventHandlers) é o `event handler` para o processamento de eventos de `click (en-US)` em um dado elemento.

   O evento `click` acontece quando o usuário clica em um elemento. É disparado após os eventos `mousedown (en-US)` e`mouseup (en-US)` na respectiva ordem.

   

   => PARTE 4

   Pensando Do Jeito React

   * Comece com um Mock
   * Separe a UI em uma Hierarquia de Componentes
   * Crie uma versão Estática em React
   * Identifique a Representação Mínima (mas completa) do State da UI
   * Identifique Onde o State Deve Ficar

   

   Containers e onde fica nossas views (visualizações)

   

