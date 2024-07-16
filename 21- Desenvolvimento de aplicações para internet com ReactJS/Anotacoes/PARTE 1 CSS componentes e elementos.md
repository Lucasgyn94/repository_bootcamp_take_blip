#### PARTE 1: CSS componentes e elementos

Como estilizar elementos utilizando React;

#### => Maneiras de estilização

## 1. Inline

E a maneira mais básica de se estilizar um componente em react:

### Exemplo 1

Criamos um arquivo Inline.jsx

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\Inline.png)



#### Exemplo2

$

const divStyle = {

​	color: 'bue';

​	backgroundImage: 'url(' + imgUrl + ')'

};

function HelloWorldComponent( ) {

​	return <div style={divStyle}>Hello World!</div>

}



#### Exemplo2

$

function App( ) {

​	reuturn (

​		<HelloWorld style={{  marginTop: '10px'  }} />

​	)

}



> Prós
>
> * Maneira mais prática e direta
> * Ajustes Rápidos
> * Testes de Estilo
>
> Contras
>
> * Difícil manutenção
>
> 

2. Classes

#### Exemplo1

Criamos um arquivo ClassName.css que contém:

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\ClassName_CSS.png)

Após, criamos um arquivo ClassName.jsx e importamos

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\ClassName_JSX.png)

### Exemplo 2

$

.div-style {

​	color: blue;

​	background: url('https://bit.ly/2L8xxHz');

}



Após importamos para function HelloWorldComponent 

$

import './HelloWorldComponent.css';

function HelloWorldComponent( ) {

​	return <div className="div-style">Hello Wold!</div>

}



> Em JSX, define-se classes pelo atributo className
>
> * Maneira mais prática e direta
>
> Contras
>
> * Difícil manutenção
> * Pouca flexibilidade
> * Conflitos com nomes



3. CSS in JS

Aqui o CSS e criado dentro do próprio javascript, e o javascript gera CSS pra nós;

Styled Components Trata-se de uma biblioteca (*lib*) que nos permite escrever códigos CSS dentro do JavaScript,

Para usar, devemos instalar no terminal o styled-components

$ npm install --save styled-components



### EXEMPLO 1

Criamos o arquivo Styled.jsx 

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\Styled_Css.png)



#### EXEMPLO 2

const DivStyle = styled.div`

​	color: blue;

​	background: url('${props => props.imageUrl}');

`;

function HelloWorldComponent () {

​	const url = 'https://bit.ly/2L8xxHz';

​	return <DivStyle imageUrl={url}>Hello World</DivStyle>;

}



> => Manutenção
>
> * Facilidade para remover CSS
> * Estilos dinâmicos
>
> => Perfomance
>
> => Injeção automática de prefixos vendor



#### PARTE 2: Stateful vs Stateless

=> Statefull

Significa que um componente usa estados;

Possui gerenciamento de estados no componente;

Construídos usando classes em Js;



#### # STATEFUL - Ciclo de Vida

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\Steteful - Ciclo de Vida.png)



## Initialization

* setup props and state

  Configurar props e estados

## Mouting

* componentWillMount
* render
* componentDidMount

## Updation

> Props
>
> 1. componentWillReceiveProps
>
>    Aqui o componente vai receber as props
>
> 2. componentWillUpdate
>
>    Componente vai atualizar
>
> 3. render
>
>    Renderizando
>
> 4. componentDidUpdate
>
>    Componente fez atualização
>
> State
>
> 1. componentWillUpdate
>
>    Componente fez Atualização
>
> 2. render
>
>    Renderização
>
> 3. componentDidUpdate
>
>    Componente fez Atualização

## Unmounting

> 1. componentWillUnmount
>
>    componente vai desmontar



## Exemplo Lista com stateful

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\Lista Supermercado.png)

=> O código desse componente fica da seguinte forma:

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\TodoListStateFull.png)



// Todo = Façam

TodoListStateFull = Estado da Lista Cheio

$

import React, {  Component  } from 'react';

class TodoListStateFull extends Component {

​	constructor(props) {

​		super(props);

​		this.state = {

​			items: [	

​				'Tomate',

​				'Alface',

​				'Melancia'

​			]

​		}

​	}

}

addItem = (item) => {

/*

[...this.state.items, item] é o mesmo que:

let itemUpdated = this.state.items;

itemUpdated.push(item);

this.setState({	items:  itemsUpdated	});

*/

this.setState({items: [...this.state.items, item]});

}

removeItem = () => {

/*

[...this.state.items.slice(1)] é o mesmo que:

let itemsUpdated = this.state.items;

itemsUpdated.pop();

this.setState({  items: itemsUpdated  });

*/

this.setState({ items: [...this.state.items.slice(1)] })

}

render() {

​	const { items } = this.state;

​	return (

​		<div className="bloco-lista"> 

​				<p>Minha Lista ClassName</p>

​				<ul className="lista-estilizada"> 

​					{items.map(item => <li>{item}</li>)}			

​				</ul>

​				<button Onclick={( ) => this.addItem('Abobora')}>Adicionar Item</button>

​				<button Onclick={( ) => this.removeItem( )}>Remover Item</button>

​	)

}

}

export default TodoListStateFull;



## Stateless

Significa que um componente não usará estados;

* Não possui  gerenciamento de estados no componente;

* Construídos usando funções em JS

  Ele e mais utilizado para renderização de algum modulo, como imagens, icones;

#### Exemplo da Lista Com StateLess

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\TodoListStateLess.png)



import React from 'react';

const TodoListStateLess = ({items}) => (

​		<div className="bloco-lista">

​				<p>Minha lista Stateless</p>

​				<ul className="lista-estilizada">

​					{items.map(item => <li> {item} </li>)}

​				</ul>

​		</div>

);

export default TodoListStateless;

===============================================

### Exemplo Componente Statefull com Hooks

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\TodoListFunctional.png)

// useState e um hook para criação de estados

import React, {  useState  } from 'react';

const TodoListFunctional = ( ) => {

​	const [items, setItems] = useState(['Tomate', 'Alface', 'Melancia']);

​	const addItem = (item) => {

​		setItems([...items, item]);

​	}

​	const removeItem = () => {

​		setItems([...items.slice(1)]) // slice = fatiar;

​	}

return (

​		<div className="bloco-lista">

​				<p>Minha Lista</p>

​				<ul className="lista-estilizada">

​					{ items.map(item => <li> {item}</li>)}

​				</ul>

​				<button onClick={() => addItem('Abobora')}>Add item</button>

​				<button onClick={() => removeItem( )}> Remove Item</button>

​		</div>

​	);

}

export default TodoListFunctional;



#### Stateful vs Stateless

=> A nomenclatura foi atualizada

* Class Components
* Function Components

=> Com hooks, estados são manipuláveis em function components!



OBS:

JSX é uma extensão que permite criar elementos para serem utilizados como templates de aplicações React.



### PARTE 3: Formularios

Os formulários mantêm o estado interno; 

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\Form.png)

<form>
    <label>
    	Nome:
        <input type="text" name="nome" />
    </label>
    <input type="submit" value="Enviar"/>
</form>


=> Em HTML, <input>, <textarea> e <select> têm um estado interno

=> Em React, podemos controlar o estado

* state

* setState

  Para fazer o merge desses dois estatos, ja que o dom tem seu proprio estado e o react tem seu proprio estado, nós temos duas formas de trabalhar, com componentes controlados e com componentes-não-controlados;

  

  ## Componente Controlado

  * Tanto select, input ou textarea aceitam um atributo value
  * Podemos mudar esse valor usando o atributo onChange

  

  ## => Exemplo NameForm

  ![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\NameForm.png)

  import React from 'react';

  class NameForm extends React.component {

  ​		constructor(props);

  ​		this.state = { value: ' ' };

  ​		

  ​		this.handleChanges = this.handleChanges.bind(this);

  ​		this.handleSubmit = this.handleSubmit.bind(this);

  }

  handleChange(event) {

  ​	this.setState({value: event.target.value});

  }

  handleSubmit(event) {

  ​	alert('O nome enviado foi:' + this.state.value);

  }

  

  render( ) {

  ​	return (

  ​			<form onSubmit={this.handleSubmit} style={{display: 'flex, flexDirection: 'column'}}>

  ​					<label>

  ​						Nome:

  ​					<input type="text" value={this.state.value} onChange={this.handleChange} />

  ​					</label>

  ​					<input type="submit" value="Submit" />

  ​					</form>

  ​	);

  }

  }
  
  export default NameForm;



## Exemplo SorveteForm

Criamos o arquivo SorveteForm.jsx

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\SorveteForm.png)

checked ser para valor inicial e para controle

event.preventDefault(); serve para que não seja feito o redirect do formulario



OBS: Um componente controlado basicamente tem sempre um 'value', onde pegaremos o estado e atelaremos a tag input, e temos uma função onChange

Ex:

<input type="text" value={this.state.value} onClange={this.handleChange}/>

## Componente não-controlado

* A tag input é read-only

No componente não-controlado vamos pegar o estado do Dom só que o react só vai observar esses estados, ou seja, ele vai pegar uma referência 'ref' desses estados para ele saber como esses estados estão sendo feitos;



E recomendado pelo react que seja feito os componentes todos controlado com exceção da tag input que tem que ser feito com componente-não controlado

=> Bibliotecas

- Formik
- Redux-forms

São mais recomendadas para projetos mais robustos



## Exemplo usando Formik

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\Formik.png)





## OBSERVACOES

bind = vindular

handleChanges = lidar com mudanças

submit = enviar

type = modelo

checkbox = caixa de verificação