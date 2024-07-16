*Internet das coisas*

Têm como objetivo conectar os itens usados do dia a dia à rede mundial de computadores. EX

*Por que conectar as coisas?*

* Embutir sensores em objetos do dia-a-dia
* Coletar dados dos sensores
* Usar o dado para tomar decisão



=> Conceitos Básicos de Iot (Internet das coisas)

A internet das coisas passa por três fases:

Things: = coisas; aonde vamos colocar nossos sensores, colocar dados

Cloud = nuvem; onde queremos processar e armazenar esses dados

intelligence = inteligencia; processo de utilizar todos esses dados gerados e se beneficiar do poder dessa rede, dessas coisas que estão todas conectadas agora, e utilizar esses dados de forma inteligente, para resolver problemas, para utilizar processos, para ter vantagem competitiva.

_*-> Desafios da Internet das Coisas*_

1. Privacidade e Segurança
2. Quantidade exponencial de dispositivos conectados na rede
3. Ser capaz de processar e armazenar uma enorme quantidade de informações
4. Gerar valor a partir dos dados coletados



=> PARTE 2: Arquitetura da Internet das Coisas

Problema a ser resolvido

Um proprietário de uma fábrica de veículos pretende saber em tempo real qual e a localização de cada um de seus veículos.

Requisitos:

- GPS em cada veículo que vai coletar a posição geográfica mais atual e vai transmitir para um servidor (nuvem);
- Os dados serão  armazenados, e uma vez armazenados poderam ser utilizados para poder criar uma aplicação que exista um mapa, e nesse mapa possa ver a localização desses veículos.



=> Conectando as coisas...

Considere esses atributos na escolha

* Baixo consumo de energia
* Rede de dados limitado
* Resiliência
* Segurança
* Customização
* Baixo Custo



=> Arduino

* Plataforma de Prototipagem
* Com entradas/saídas
* Desenvolvedor escreve em C/C++
* Interface serial ou USB
* Shields



=> Embarcados

_*MCUs*_

* Microcontrolador de chip único
* Sistema operacional real time
* Embarcado
* Uso industrial, médico, militar, transporte



=> Minicomputadores

_*Raspberry Pi*_

* Computador completo
* Hardware integrado em uma única placa
* Roda SO Linux ou Windows
* Uso doméstico e comercial



=> Voltando ao exercício

_*O protocolo de comunicação*_

=> O protocolo MQTT

MQTT(Message Queuing Telemetry Transport) é um protocolo de comunicação máquina para máquina (M2M - Machine to Machine) com foco em Internet of Things (IoT) que funciona em cima do protocolo TCP/IP. Um sistema MQTT se baseia na comunicação entre cliente e servidor, em que o primeiro pode realizar tanto “postagens” quanto “captação” de informação e o segundo administra os dados a serem recebidos e enviados.

_*MQTT*_

* Base na pilha do TCP/IP
* Protocolo de mensagem assíncrona (M2M)
* Criado pela IBM para conectar sensores de pipelines de petróleo a satélites
* Padrão OASIS suportado pelas linguagens de programação mais populares

Subscribe é a capacidade que um client http, um software, um device, tem de se conectar ao brocker e passar a ouvir um tópico.

o + no lugar de user, faz buscar todas as informações e não só de um cliente.

"#" = O brocker entrega todas as mensagens dos topicos internos, buscar mensagens de todos os usuarios, e de todos os sensores e suas informacoes;

=> Níveis de Qos

Existem 3 Níveis diferentes de qualidade de serviço: QoS 0, QoS 1, QoS 2;

*QoS 0*

* Nível mínimo de menor esforço
* Sem garantia de entrega
* Mensagem não é retransmitida

_*QoS 1*_

* Garante que a mensagem foi entregue no mínimo uma vez ao recebedor
* Mensagem pode ser retransmitida se não houver confirmação de entrega

_*QoS 2*_

* Garante que a mensagem foi entregue no mínimo uma vez ao recebedor
* Mensagem pode ser retransmitida se não houver confirmação de entrega
* É o nível mais caro e que mais garante que a mensagem vai chegar;

=> CLOUD

* cloud = nuvem
* Grande e cada vez maior número de devices conectados
* TBs ou PBs de informação
* Potencial de escala global

-> Data store = armazena cada posição geográfica recebida identificando usuário, data e hora permitindo reconstruir rotas inteiras;

OBS:

worker basicamente é a aplicação, o código, a regra de negócio;

O brocker apenas rotea as mensagens que estão chegando nele;

=> PARTE 3: Estudo de Casos

-> Lambda

Lambda é uma função



================================================

OBSERVAÇÕES DE PESQUISA

TCP/IP é o principal protocolo de envio e recebimento de dados MS internet. TCP significa Transmission Control Protocol (Protocolo de Controle de Transmissão) e o IP, Internet Protocol (Protocolo de Internet).

protocolo é uma espécie de linguagem utilizada para que dois computadores consigam se comunicar. Por mais que duas máquinas estejam conectadas à mesma rede, se não “falarem” a mesma língua, não há como estabelecer uma comunicação. Então, o TCP/IP é uma espécie de idioma que permite às aplicações conversarem entre si.

Na realidade, o TCP/IP é um conjunto de protocolos. Esse grupo é dividido em quatro camadas: aplicação, transporte, rede e interface. Cada uma delas é responsável pela execução de tarefas distintas. Essa divisão em camadas é uma forma de garantir a integridade dos dados que trafegam pela rede.



