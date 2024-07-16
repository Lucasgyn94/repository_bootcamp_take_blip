### OBJETIVOS DA AULA

1. [Fragmentos]
2. [Erros Boundaries] = limite de erro
3. [Render props]
4. [Typechecking com PropTypes]
5. [Refs e DOM]



## => Fragments (fragmentos)

"É um padrão comum no React é que um componente pode retornar múltiplos elementos. Os Fragmentos permitem agrupar uma lista de filhos sem adicionar nós extras ao DOM."



### EXEMPLO

### Forma 1

Usando React.Fragment

![](C:\Users\Admin\Desktop\DigitalOne\22- Práticas avançadas em projetos com ReactJS\PNGs\12- Fragments.png)



### Forma 2

Importando Fragment e retornando somente Fragment

![](C:\Users\Admin\Desktop\DigitalOne\22- Práticas avançadas em projetos com ReactJS\PNGs\13- Fragments2.png)



### Forma 3

Importando React, {Fragment} e returnando sintaxe shoulder <></>

![](C:\Users\Admin\Desktop\DigitalOne\22- Práticas avançadas em projetos com ReactJS\PNGs\14- Fragments3.png)



## EXEMPLO 2

![](C:\Users\Admin\Desktop\DigitalOne\22- Práticas avançadas em projetos com ReactJS\PNGs\15- Fragments4.png)



## => Error Boundaries (limites de erro)

"É um erro de JavaScript em uma parte da UI não deve quebrar toda a aplicação. Para resolver este problema para usuários do React, o React 16 introduziu um novo conceito de "error boundary"." 

1- criação arquivo ErrorBoundary.js

![](C:\Users\Admin\Desktop\DigitalOne\22- Práticas avançadas em projetos com ReactJS\PNGs\16 - ErrorBoundary_Erro.png)



2- Importar ErrorBoundary para index.js

![](C:\Users\Admin\Desktop\DigitalOne\22- Práticas avançadas em projetos com ReactJS\PNGs\19- Index_ImportBoundary.png)



3- App.js com erro de tela quebrada

![](C:\Users\Admin\Desktop\DigitalOne\22- Práticas avançadas em projetos com ReactJS\PNGs\17- AppError_type.name.console.png)



4. App sem erro de tela quebrada

![](C:\Users\Admin\Desktop\DigitalOne\22- Práticas avançadas em projetos com ReactJS\PNGs\18-App_SemErro.png)



### Error boundaries não capturam erros em:

* Manipuladores de evento;
* Código assíncrono (ex. callbacks de SetTimeout ou requestAnimationFrame)
* Renderização no servidor;
* Erros lançados na própria error boundary (ao invés em seus filhos);

OBS:

request animation frame = solicitar quadro de animação



## =>RENDER PROPS

"O termo "render prop" se refere a uma técnica de compartilhar código entre componentes React passando uma prop cujo valor é uma função.

Um componente com uma render prop recebe uma função que retorna um elemento React e a invoca no momento de renderização, não sendo necessário para o componente implementar uma lógica própria."

### EXEMPLO

1- index.js

![](C:\Users\Admin\Desktop\DigitalOne\22- Práticas avançadas em projetos com ReactJS\PNGs\20-RenderPropsIndex.png)

2- App.js

a classe App vai renderizar as funções de incremento, decremento e count que está sendo passada atráves de Counter.js

![](C:\Users\Admin\Desktop\DigitalOne\22- Práticas avançadas em projetos com ReactJS\PNGs\21- RenderAppJS.png)



3- Counter.js

Criamos um rapper, que tem dois metodos, 'increment' e 'decrement', e ele recebe  um 'count' como valor inicial 0, e o return dele, será o render do decremento e incremento, passado pelo Buttons em App.js



![](C:\Users\Admin\Desktop\DigitalOne\22- Práticas avançadas em projetos com ReactJS\PNGs\22-CounterJS.png)



## => Typechecking

"Na medida em que sua aplicação cresce, você pode capturar com checagem de tipos. Em algumas aplicações, você pode usar extensões do JavaScript como Flou ou TypeScript para checar os tipos de toda a sua aplicação. Porém, mesmo se você não usá-las, React possui algumas habilidades de checagem de tipos nativas."



### EXEMPLOS

=> Biblioteca de checagem:

$ import PropTypes from 'prop-types'

### 1- Suponha que vamos criar um petshop, arquivo 'PetShop.js',  que não entrou valor, usaremos PropTypes para defini-los.

![](C:\Users\Admin\Desktop\DigitalOne\22- Práticas avançadas em projetos com ReactJS\PNGs\23- PetShopJS.png)



2- Importar petshop para App.js

![](C:\Users\Admin\Desktop\DigitalOne\22- Práticas avançadas em projetos com ReactJS\PNGs\24-App_PetshopJS.png)



defaultProps são propriedades padrão da aplicação



### EXERCICIO FINAL

Criar um componente que receba propriedade do tipo "array", "bool", "func", "number", "object", "string" e realizar a validação utilizando Prop-Types.

Colocar como defaultProps os valores string e number;



## => REFS E DOM

Com Refs é possível acessar a árvore do DOM e/ou elementos React.

Quando utilizar:

* Manipulação de bibliotecas de terceiros
* Gerenciamento de inputs (foco), seleção de textos ou reprodução de mídias;
* Animações imperativas.



### EXEMPLO

1- Em 'App.js', renderizando setTimeout uma vez

![](C:\Users\Admin\Desktop\DigitalOne\22- Práticas avançadas em projetos com ReactJS\PNGs\25-refsDom_renderizandoUmaVez.png)

importar React, {useRef} from 'react'

current = atual

### 2- 'App.js' caso precise renderizar novamente fica da seguinte forma de 1 para 300 com useState:

![](C:\Users\Admin\Desktop\DigitalOne\22- Práticas avançadas em projetos com ReactJS\PNGs\26-refsDom_renderizandoNovamente.png)



### EXERCICIO FINAL

Criar um elemento e utilizar a referência dele;