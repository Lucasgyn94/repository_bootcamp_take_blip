### => OBJETIVOS DA AULA

1. TDD e BDD com Jest
2. Debuggin
3. Tratamento de erros

### => REQUISITOS BÁSICOS

* Ter feito as Aulas 1, 2 e 3
* Editor de Texto
* Ter o Node.js e React corretamente instalados;



### O QUE É TDD

* Test-Driven Develpment (Desenvolvimento orientado a teste)
* Antecipar erros a nível de desenvolvimento
  * Teste escrito antes da funcionalidade

* Não descarta a presença de um tester
* Tem como objetivo testar um código para testar o meu próprio código



### => Ciclo de Vida TDD

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\TDD.png)

=> O TDD tem duas vertentes

1. Teste Unitário
2. Teste End-to-End (E2E)

Para fazer esses testes, temos algumas bibliotecas que nós auxiliam:

* Jest
* React-Testing-Library
* Shallow
* Enzyme
* Chai
* Mocha
* Selenium
* Puppeteer



### => Agora vamos fazer o teste com Jest

Imagine a função soma

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\Teste.png)

Para fazer o teste dessa função temos que primeiro:

### Instalar o Jest

site: jestjs.io

O Jest utiliza uma linguagem javascript, chamada Jasmine, para que consigamos fazer nossos testes em Jest, precimos também do Jasmine;

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\describe.png)

No código acima temos um describe onde descrevemos o que a nossa bateria de testes faz, e cada bateria de testes tem um teste unitário que chamos de 'it' que tem uma descrição, e no it, temos uma variavel a true, e é esperado que a seja = true

(expec(a).toBe(true)); = esperado que 'a' seja true

### => A nossa função soma em um teste fica da seguinte forma:

Primeiro importamos a nossa função soma:

![]()![TesteFuncao](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\TesteFuncao.png)

Basicamente nesse exemplo importamos nossa função soma, após, iremos descrever nossa bateria de teste testando a função soma, onde temos um teste unitário em que a soma deve dar 3, e nos chamamos a função 1, 2 e nos recebemos um resultado, esperando que esse resultado seja = 3, se a nossa função tiver implantada corretamente, 1 + 2 = 3 e vai da tudo certo;



### COMO TESTAR UM COMPONENTE EM REACT?

Para isso iremos instalar duas bibliotecas

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\TesteBiblioteca.png)

$ yarn add --dev @testing-library/react

// Para extensões de comparação no jest

$ yarn add --dev @testing-library/jest-dom/extend-expect

### Para o nosso teste, iremos tomar como base um componente chamado Basic;

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\TDDBasic.png)

### Para testarmos fica o seguinte:

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\TddTeste.png)

expect(baseElement).toHaveTextContent('Meu nome é Lilith');

(esperado que o elemento de base tenha conteúdo de texto ('Meu nome é Lilith'))



### TESTE 2

Vamos testar o counter da aula 2

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\TDD Counter.png)



### Para testar fica o seguinte:

Estratégia para teste com componentes que utilizam Redux

* Nós temos que criar uma Store/ Provider de teste e fazer um rapper para conseguir testar esse componente;

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\TDDReducer.png)



## =<> O QUE É BDD

* Behavior-Driven Development (desenvolvimento orientado por comportamento)
* Teste de especificação
  * Une especificação, teste automatizado e premissa de teste (documento de teste)



=> BDD e sintaxe Gherkin

* Sintaxe de steps para definir cenários
* Descreve cada funcionalidade por feature (caso de uso);
* feature = característica

### Como funciona essa sintaxe Gherkin?

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\BDD.png)

Imagine que você tem na sua especificação, uma funcionalidade 'Login' e dois cenários, de login váligo e inválido;

### Para trabalhar com teste BDD podemos utilizar uma das seguintes bibliotecas que são mais comuns

* Jest-cucumber
* Chai

### Para instalar o Jest-cucumber digitamos o seguinte comando no terminal:

$ yarn add --dev jest-cucumber



=> Agora vamos ao teste

Temos aqui uma função soma que retorna a + b

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\BDDSoma.png)

### Para testar fica o seguinte:

Primeiro instalamos também a extensão do vsCode Cucumber(Gherkin) de Alexander Krechik

Após, o código e este:

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\BDDFeature.png)

### E por fim para testar usando cucumber fica da seguinte forma:

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\BDDTeste.png)





## PARTE 2: Debbugging

=> Debbuggin

Depuração é o processo de encontrar e reduzir defeitos em um software.

As ferramentas de depuração mais comuns são:

* Chrome Devtools
* Redux Devtools
* React Devtools



### PARTE 3: Tratamento de erros

Serve para trazer resiliência ao software

* Resiliência de SW
* Segurança



=> Exemplo de tratamento de erros para funções

Imagina a seguinte função

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\Erros.png)

Uma forma de tratar erros nessa função seria

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\TratErros.png)



### Tratamento de erros em form

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\TratamentoForms.png)

required = obrigatório / requirido



### Tratamento de Erros

* Tratamento em retornos de APIs

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\TratamentoErros.png)

* A função exibirMensagem(error.code) tratamos por código de servidor:

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\ErroExibirMensagem.png)



### Abordagens Tratamento de Erros

* Em JS usamos PropTypes.
* Podemos usar linguagens tipadas como TypeScript, definindo interfaces.



### Tratamento basic topico 1

![](C:\Users\Admin\Desktop\DigitalOne\21- Desenvolvimento de aplicações para internet com ReactJS\ErrosComponentes.png)
