=> Serviços Web

* Serviços Web ou Web Services são soluções para aplicações se comunicarem independentemente de linguagem, softwares e hardwares utilizados.

* Inicialmente Serviços Web foram criados para troca de mensagens utilizando a linguagem XML (Extensible Markup Language) sobre o protocolo HTTP sendo identificador por URI (Uniform Resource Identifier).

* Podemos dizer que Serviços Web são API's que se comunicam por meio de redes sobre o protocolo HTTP.

=> Vantagens utilizar web service
* Linguagem Comum
* Integração
* Reutilização de implementação
* Segurança
* Custos

=> Principais Tecnologias
* SOAP
* REST
* XML
* JSON

-> SOAP
* soap - Simple Object Access Protocol

* É um protocolo baseado em XML para acessar serviços web principalmente por HTTP.

* Pode-se dizer que SOAP é uma definição de como serviços web se comunicam.

* Foi desenvolvido para facilitar integrações entre aplicações.

# Vantagens
* Permite integrações entre aplicações, independente de linguagem, pois usa como linguagem comum o XML.

* É independente de plataforma e software.

* Meio de transporte genérioco, ou seja, pode ser usado por outros protocolos além do HTTP.

# Estrutura SOAP
* O "SOAP Message" possui uma estrutura única que deve sempre ser seguida.
 - SOAP Envelope
 - SOAP Header
 - SOAP Body

* SOAP Envelope é o primeiro elemento do documento e é usado para encapsular toda a mensagem SOAP.

* Soap Header é o elemento onde possui informações de atributos e metadados da requisição.

* SOAP Body é o elemento que contém os detalhes da mensagem.

Ex:

<soap: Envelope xmlns:soap="http://www.w3.org/2003/05/soap-envelope">

​	<soap: Header> 

​	</soap:Header>

​	<soap:Body>

​		<m:MetodoEndereo xlmns:m="http://www.example.org/endereco">

​			<m:Cidade> Rio de Janeiro </m:Cidade>

​			<m:CEP> 99999-999 </m:CEP>

​			<m:Logradouro> Avenida Atlântida </m:Logradouro>

​			<m:Numero> 99 </n:Numero>

​		</m:Endereco>

​	</msoap:Body>

</soap:Envelope>

=> XML

* XML - Extensible Markup Language
* É uma linguagem de marcação criada na década de 90 pela W3C.
* Facilita a separação de conteúdo.
* Não tem limitação de criação de tags
* Linguagem comum para integrações entre aplicações.



=> WSDL

* WSDL - Web Services Description Language.
* Usado para descrever Web Services, funciona como um contrato do serviço.
* A descrição é feito em um documentação de como deve ser montado o SOAP Message (XML) que será enviado através de Web Service.

=> XSD

* XSD - XML Schema Definition
* É um schema no formato XML usado para definir a estrutura de dados que será validada no XML.
* O XSD funciona como uma documentação de como dever montado o SOAP Message (XML) que será enviado atráves de Web Service.

=> REST

*  REST - Representational State Transfer.
* É um estilo de arquitetura de software que define a implementação de um serviço web.
* Podem trabalhar com os formatos XML, JSON ou outros.

-> Vantagens do REST

* Permite integrações entre aplicações e também entre cliente e servidor em páginas web e aplicações.
* Utiliza dos métodos HTTP para definir a operação que está sendo efetuada.
* Arquitetura de fácil compreensão.

-> Estrutura do REST

* Cliente faz Requisição HTTP para o Servidor, e esse servidor vai retornar um código de operação (se deu falha ou sucesso) e uma mensagem.
* Uma Requisição HTTP tem métodos (GET, POST, PUT, DELET...)
* Quando uma aplicação web disponibiliza um conjunto de rotinas e padrões através de serviços web podemos chamar esse conjunto de API.

-> Principais Métodos HTTP

GET - Solicita a representação de um recurso.

POST - Solicita a criação de um recurso.

DELETE - Solicita a exclusão de um recurso.

PUT - Solicita a atualização de um recurso.

=> API

* API - Application Programming Interface
* São conjuntos de rotinas documentados e disponibilizados por uma aplicação para que outras aplicações possam consumir suas funcionalidades.
* Ficou popular com o aumento dos serviços web.
* As maiores plataformas de tecnologias disponibilizam APIs para acesso de suas funcionalidades, algumas delas são: Facebook, Twitter, Telegram, Whatsapp, GitHub...

=> JSON

* JSON - JavaScript Object Notation.
* Formatação leve utilizada para troca de mensagens entre sistemas.
* Usa-se de uma estrutura de chave e valor e também de listas ordenadas.
* Um dos formatos mais populares e mais utilizados para troca de mensagens entre sistemas.

-> Exemplo Estrutura JSON

{

​	"nome": "Os Vingadores",

​	"ano_lancamento" : "2019",

​	"personagens" : [

​			{

​					"nome": "Thanos"

​			},

​			{

​					"nome": "Homem de Ferro"

​			},

​			{

​					"nome": "Thor"

​			}

​	]

}



=> Código de Estado

* Usado pelo servidor para avisar o cliente sobre o estado da operação solicitada.
* 1xx - Informativo
* 2xx - Sucesso
* 3xx - Redirecionamento
* 4xx - Erro do Cliente
* 5xx - Erro do Servidor

