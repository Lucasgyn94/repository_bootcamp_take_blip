## OBJETIVOS DA AULA

1. [Dumb Components]
2. [Smart Components]
3. Organização de Projeto



## => Dumb Components

* Preocupa-se com a apresentação
* Recebem valores via props
* Não possuem dependências com o restante da aplicação
* Não especificam como os dados são carregados ou sofrem mutação.
* Recebem valores e callbacks exclusivamente via props;
* Raramente possuem estado, quando precisam de estado é para controlar a interface e não dados do usuário;
* São escritos na maioria das vezes como componentes funcionais.

=> Exemplos: Button, Card, Sidebar, Footer, List, Menu



### EXEMPLO PRÁTICO Dumb-Components

1- Criamos uma pasta Component, que contém a pasta Button e dentro um arquivo 'index.js' que cria o nosso button.

![](C:\Users\Admin\Desktop\DigitalOne\22- Práticas avançadas em projetos com ReactJS\PNGs\27-Button_Dumb_Comp.png)

Ela é um componente 'burro', sem ação nenhuma, apenas cria o componente, todas as ações ficará no container App.js.



2- Criamos uma pasta Calc dentro de Component que contém um index.js:

![](C:\Users\Admin\Desktop\DigitalOne\22- Práticas avançadas em projetos com ReactJS\PNGs\28-Calc_Dumb_Comp.png)



3- E no nosso App.js teremos as ações:

![](C:\Users\Admin\Desktop\DigitalOne\22- Práticas avançadas em projetos com ReactJS\PNGs\29-App_Dumb_Comp.png)



OBS: DUMB são componentes sem estado e regra e totalmente desacoplados

### EXERCICIO FINAL

Criar um componente sem estado, que receba propriedades e aplique-as.

Sugestão de componente: Tabela.



## => Smart Components

Preocupam-se como as coisas vão funcionar.

Podem conter Smart e Dumb Components.

Providenciam dados e padrões de apresentação ou outros containers.

Na maioria dos casos possuem estado e podem chamar outros fluxos sistema.

Exemplos: UserGallery, UserPage, FilterBook, FollowersSidebar, ListCards

Utilizar o memu para eviatar um re-render desnecessário



1- Primeiro, criaremos nossa pasta Component que contém a pasta Button e PhotosGallery, em Button, criamos o 'index.js' a seguir:

![](C:\Users\Admin\Desktop\DigitalOne\22- Práticas avançadas em projetos com ReactJS\PNGs\30- Button_SmartComp.png)



2- Apos, na pasta 'PhotosGallery' criaremos nosso 'inder.js' contendo:

![image-20220103174236587](C:\Users\Admin\AppData\Roaming\Typora\typora-user-images\image-20220103174236587.png)



3- Após, o nosso container App.js fica da seguinte forma

![](C:\Users\Admin\Desktop\DigitalOne\22- Práticas avançadas em projetos com ReactJS\PNGs\31- App_SmartComp.png)

OBS:

Smart components geralmente tem estado, possuem regras, manipulam dados externos, conseguem manipular o fluxo da aplicação, conversar com qualquer parte da aplicação.

### site utilizados pra imagem: https://placeimg.com/



### EXERCICIO FINAL

Criar um componente com estado, que receba propriedade e aplique-as.

Sugestão de componente: Galeria de fotos



## Finalizando o Projeto

### Criando uma Estrutura de Projeto (structure-project)

* App.js e a página inicial da aplicação, ou seja, o Main, nela podemos colocar rotas, provider, fluxo de autenticação, validação, tudo que for global, não colocamos os componentes diretamente, somente as rotas;

* assets = bens, contém os arquivos globais

* commons = bens comuns, contem

* No arquivo 'index.js' principal, fazemos a importação de todos nossos componentes.

  * Suponha uma pasta components que contém um arquivo 'index.js', e ademais outras subpastas, como Button, Calc, PhotoGallery, cada uma com seus respectivos index.js. No arquivo 'index.js' de components, devemos fazer a importação de todos componentes(subpastas)

    $

    * import Button from './Button'
    * import Calc from './Calc'
    * import PhotoGallery from './PhotoGallery'

  * Após, fazemos o export novamente:

    $

    * export {

      Button,

      Calc,

      PhotoGallery

      }

* A pasta util contém arquivos utilitarios, exemplo, 'string.js', tudo que for reaproveitavel no sistema

  * As funções devem ter responsabilidades únicas

*  A pasta constants contém constantes que serão fixas na aplicação

  * Ex: 

    $ const MENU = [

    'gallery',

    'photos',

    'shop',

    'store',

    'bank'

    ]

    export default MENU;

    

    EX FORMA 2:

    $ export const MENU = [

    'gallery',

    'photos',

    'shop',

    'store',

    'bank'

    ]

    

* Tudo que for comum ao sistema criamos dentro de commons
* Em resources (recursos) colocamos nossas chamadas de serviço (api)
* Em routes, temos nossas rotas