=> Tipos de Arquitetura

_*Monolito*_

Uma única aplicação tem acesso ao banco de dados, aplicações e a todas informações.

_*Microsserviços#1*_

Várias aplicações tem acesso ao banco de dados, instancias, etc;

Vários Serviços acoplados um ao outro;



*Microsserviços #2*

Unico ponto de comunicação entre os serviços denomminado Message Broker, guarda determinado serviço em caso de caída ate o serviço voltar.



_*Microsserviços #3*_

Cliente (web app/mobile app) faz a comunicação Proxy htpp, o Proxy Http redireciona para o Gerenciador de pipeline que distribui para os terminais de serviço compatível. 



=> Pros e Contra Monolito

*Pros*

* Baixa complexidade
* Monitoramento simplificado

*Contra*

* Stack única
* Compartilhamento de recursos
* Acoplamento
* Mais complexo a escalabilidade



=> Pros e contra Microsserviços #1

*Pros*

* Stack dinâmica(trabalha em várias linguagens)
* Simples escalabilidade



*Contra*

* Acoplamento
* Monitoramento mais complexo
* Provisionamento mais complexo



=> Pros e contra Microserviços #2

*Pros*

* Stack dinâmica
* Simples escalabilidade
* Desacoplamento

*Contra*

* Monitoramento mais complexo
* Provisionamento mais complexo



=> Pros e contra Microsserviços #3

*Pros*

* Stack Dinâmica
* Simples escalabilidade
* Desacoplamento
* Menor complexidade

*Contra*

* Provisionamento mais complexo
* Plataforma inteira depende do gerenciador de pipeline



=> Gerenciamento de erros

*Onde é mais complexo:*

* Processos assíncronos (Microsserviços #2)
* Pipeline

*Solução*

* Dead letter queue
* Filas de re-tentativas

OBS:

rollback = reversão











