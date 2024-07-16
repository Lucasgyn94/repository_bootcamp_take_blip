=> No prompt de comando, já na pasta que vamos criar o projeto, executamos

$ nmp init -y

$ npm install --save-dev webpack webpack-cli

$ npm install --save-dev @babel/core babel-loader @babel/preset-env @babel/preset-react

=> Após instalação desses pacotes, iremos abrir o nosso projeto:

$ code .

=> Na pasta do projeto criamos o arquivo '.babelrc', ele dita as regras que o babel deve utilizar; Nele adicionamos os nossos "presets": que é um array [ ] contendo o "babel/preset-env" e o "babel/preset-react", ficando da seguinte forma:

{

"presets": [

​		"@babel/preset-env",

​		"@babel/preset-react"

​	]

}

=> Agora devemos adicionar também ao nosso projeto a pasta 'webpack.config.js'. Esse arquivo e onde vai ter as instruções para que o webpack saiba o que fazer com esses arquivos antes de gerar o nosso bundle, o nosso pacote; Esse arquivo vai ser utilizado pelo node para criar o nosso bundle da aplicação react:

module.exports = {

​	module: {

​		rules: [

​			{

​				test: /\ .(js|jsx)$/,

​				exclude: /node_modules/,

​				use: {

​					loader: "babel-loader"

​				}

​			}

​		]

​	}

};



=> Após tudo feito, voltamos ao terminal e vamos instalar as dependências do react 'react' e 'react-dom':

$ npm install --save react react-dom



=> Após, voltamos ao projeto e criamos a nossa pasta 'src' contendo o nosso 'index.js' e importa as duas bibliotecas que utilizaremos:

$ import React from 'react';

$ import ReactDOM from 'react-dom';

=> Agora abaixo criaremos um componente funcional App

const App = () => {

​	return <h1> NavBar</h1>>

};

=> Agora usamos a reactDom para dizer onde ele vai renderizar esse componente:

const container = document.getElementById("root");

container ? ReactDOM.render(<App />, container) : false;



=> Agora vamos criar o documento root que será um 'index.html':

<!DOCTYPE html>
<html>
    <head>
        <meta charset="UTF-8">
        <title>WebPack</title>
    </head>

    <body>
        <div id="root"></div>
    </body>
</html>

=> Agora, voltando ao terminal,  vamos instalar as dependencias para o webpack saber o que fazer com o index.html:

$ npm install --save-dev html-webpack-plugin html-loader

  => Agora, voltamos ao webpack.config.js e iremos falar para ele o que fazer quando encontrar esse arquivo, então colocaremos mais uma regra:

{

​	test: /\ .html$/,

​	use: {

​		loader: "html-loader"

​	}

}

=> E agora adicionamos uma nova chave logo depois desse módulo, plugins que será um array, e eu vou falar pra ele usar o plugin que acabou de instalar que é o HtmlWebPackPlugin, para isso:

$ const HtmlWebPackPlugin = require("html-webpack-plugin")

plugins: [

​	// fazer a instancia do plugin:

​	new HtmlWebPackPlugin ({

​		"template": "./public/index.html",

​		"filename": "./index.html"

​	})

]

=> Agora vamos executar o nosso projeto, para isso iremos ao nosso package.json e adicionamos ao script:

"buid": "webpack --mode production",



=> Agora precisamos trabalhar em modo desenvolvimento, para isso iremos instalar a biblioteca webpack-dev-server que cria um servidor de desenvolvimento e deixa o ambiente melhor de programar;

$ npm install --save-dev webpack-dev-server



=> ERRO DE MODO

Compiled with problems:X

WARNING

configuration The 'mode' option has not been set, webpack will fallback to 'production' for this value. Set 'mode' option to 'development' or 'production' to enable defaults for each environment. You can also set it to 'none' to disable any default behavior. Learn more: https://webpack.js.org/configuration/mode/



* Para resolver este erro basta ir ao package.json e alterar a versão do webpack para "3.8.1" e executar o comando:

  $ npm install

  

### ULTIMA PARTE ESLINT
ESLint é uma ferramenta de análise de código estática para identificar padrões problemáticos encontrados no código JavaScript. Foi criado por Nicholas C. Zakas em 2013.

Instalação
- No terminal
$ npm install --save-dev eslint babel-eslint eslint-plugin-react eslint-watch

* Apos na pasta script adiciona: 
"eslint": "eslint ./src/*.js"

E para executar o Eslint, executamos no terminal
$ npm run eslint

Com o 'sourcemap'O webpack vai gerar o mapeamento de todos os arquivo
sourcemap: true





> ANOTAÇÃO RELEVANTES

O webpack é um empacotador de módulos estáticos para aplicações JavaScript modernas. Ao processar a aplicação o webpack gera um gráfico que mapeia cada módulo e suas dependências e gera um ou mais pacotes.



Babel é um transcompilador de JavaScript gratuito e de código aberto usado principalmente para converter o código ECMAScript 2015+ em uma versão compatível com versões anteriores de JavaScript que pode ser executada por mecanismos JavaScript mais antigos.

