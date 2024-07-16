## GERADOR FRASES NARUTO

1- Populando 'index.js' da pasta src

![](C:\Users\Admin\Desktop\DigitalOne\23- Introdução ao React Hooks\PNGs_Hooks\1-IndexJsPrincipal.png)

A única coisa que ele tem de diferente para um projeto pré-lançado, é o {GlobalStyle}, que vem do styled components, que é a biblioteca que iremos usar.

Site: https://styled-components.com/



2- Populando globalStyle.js

* Aqui aplicamos um css global, um css que vai ser usado pela aplicação inteira

![](C:\Users\Admin\Desktop\DigitalOne\23- Introdução ao React Hooks\PNGs_Hooks\2-GlobalStyleCss.png)



3- Dentro de src, criamos uma pasta chamada 'pages', onde teremos as páginas de nossa aplicação. A pasta 'pages' contém um index.js e uma subpasta 'App', que contém um arquivo 'index.js' contendo a página principal de nossa aplicação

![](C:\Users\Admin\Desktop\DigitalOne\23- Introdução ao React Hooks\PNGs_Hooks\3-AppJS_Pages.png)



### Criando páginas e seus respectivos testes

Fazendo nosso teste na classe App.js falhar

![](C:\Users\Admin\Desktop\DigitalOne\23- Introdução ao React Hooks\PNGs_Hooks\4-TesteAppFail.png)



Para passar, o nosso App.js fica da seguinte forma

![](C:\Users\Admin\Desktop\DigitalOne\23- Introdução ao React Hooks\PNGs_Hooks\5-App_Passa_Teste.png)



### QUOTES JS QUEBRANDO

Pasta Quotes.js

![](C:\Users\Admin\Desktop\DigitalOne\23- Introdução ao React Hooks\PNGs_Hooks\6- QuotesJS_quebrando.png)



Pasta Quotes_test.js

![](C:\Users\Admin\Desktop\DigitalOne\23- Introdução ao React Hooks\PNGs_Hooks\7- QuotesJS_Teste.png)



### Criar pasta service e colocar 'index.js'

Dentro criaremos um serviço, uma função, que no caso vai ser um serviço dentro da pasta 'service' chamado quotesService, responsável por chamar o servidor e me trazer a frase aleatória:

$ export * from './quotesService';



### Mocar riquisições

Usamos a biblioteca msw, que é feita para mocar riquisiçóes da arvore usando 'service worker';

Service Worker e uma tecnologia usada pelos browser para ficar ali na camada de rede

$

import {	rest	} from 'msw';

import {	setupServer	} from 'msw/mode';

import {	getQuote	} from './quotesService'



### Transformar json que vier da respotas em objeto javaScript

### Função assincrona

test('transform json response into object', asyn () => {

​	const quote = await 

});



### Configurar servidor ficticio que vai responder o meu teste



OBS: JSON é basicamente um formato leve de troca de informações/dados entre sistemas.

OBS2: await e para lidar com coisas assíncronas, ele aguarda promisses, requisições etc













### Tipar propriedas

É uma boa prática;

EX:

import {	string	} from 'prop-types';

serve para dizer que receberemos somente texto no componente

$

Quotes.propTypes = {

​	quote: string,

​	speaker: string

}



### Observações

### => Cor hexacimal de qualquer fundo

Usamos o programa ColorPick Eyedropper



### => Fazer mudar cor ao passar o mouse por cima

$

$: hover {

background: 

}



## .env

são variáveis de ambiente e servem para agente conseguir ter uma url no ambiente de desenvolvimento, ou seja, eu posso chamar a api na minha própria máquina, no meu ambiente de desenvolvimento e ter uma outra url quando o site popular o mesmo, bastando trocar esse arquivo, depois nesse processo de build, ele vai resolver tudo;

$ 

export const getQuote = () =>

​	fetch(process.env.REACT_APP_API).then((response) => response.json());



### useState

um useState tem como parametro um estado e uma função, essa função serve para atualizar nosso state;



### useEffect

serve para reagir a propriedades

$

useEffect(() => {

​	console.log('quoteState foi alterado');

}, [quoteState]);



### Error~e 

can't perform a React state update on an unmounted component = voce não pode realizar uma atualização de estado do React em um componente desmontado

=> A solução

Para se prevenir disso, utilizaremos outro hook, que vai dizer se o componente está montando ou desmontado antes de atualizar o state

$ 

export function App () {

let mounted = true;

}

### E no useEffect temos

useEffect(() => {

​	onUptade();

​	return () => {

​		mounted= false;

​	};

} [ ] );



### RESOLVER RENDERIZANDO 2 VEZES COM HOOK

usamos useRef, ele mantém o estado mesmo após as atualizações

$

const [quoteState]

 





### Algumas traduções

let = deixe

find = achar/ encontre

test('calls api on button click and and update is text', () => {

})

'calls api on button click and update is text = chame uma api ao clicar no botão e atualize o texto

getByRole = obter papel

then = então

fetch = buscar

toScrictEqual = exatamente igual

server.close = desliga o servidor de mock

afterAll = final de tudo

server.resetHandlers = reseta manipuladores, faz voltar a estaca 0

after each = depois de cada um / após cada

linc = escutar/ ouvir

func = tipo função

fireEvent = serve para simular interações do usuário

jest.fn = serve para criarmos funções que dizem se elas foram chamadas ou não

call = ligar

callback = ligar de volta

call a callback when button is pressioned =  chamar um retorno de chamada quando o botão for pressionado

hover = flutuar

vw = largura da tela;

vh = altura da tela

quotes = citação

content = contéudo

screen.getByText = tela.obterPorTexto

expect(quoteEl).toBeInTheDocument() = esperado que o contéudoEl esteja no documento

background-size cover = garante que o fundo vai cobrir a tela inteira (tampa do tamanho do fundo)

em = unidade relativa, equivale ao tamanho da fonte que tiver definida na raíz

flex 1 = força empurrar até o máximo