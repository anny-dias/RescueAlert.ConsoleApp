

# RescueAlert

Sistema de monitoramento de falhas de energia com impacto cibernético, voltado para o atendimento de pessoas vulneráveis em situações de emergência. Desenvolvido como parte de um projeto acadêmico em C#, utilizando arquitetura em camadas e boas práticas de programação.

---

## Objetivo

Desenvolver um sistema que apoie a resposta emergencial em casos de apagões, desastres naturais e falhas urbanas, focando no atendimento de idosos, pessoas com deficiência e pessoas em situação de pobreza. A solução permite o registro de falhas, geração de alertas e análise de status em tempo real.

---

## Funcionalidades

- Autenticação obrigatória para operadores
- Cadastro de pessoas vulneráveis (classificadas por tipo)
- Registro de falhas de energia
- Geração de alertas emergenciais associando pessoas a falhas
- Relatórios de status dos alertas
- Listagem de falhas e pessoas registradas
- Registro de logs de eventos em arquivo `.txt`
- Validação de entradas com `try-catch` (datas, campos vazios, etc.)

---

## Arquitetura e Estrutura

O projeto segue a arquitetura em camadas, com separação em bibliotecas de classes:

RescueAlert
├── ConsoleApp              # Interface principal em console
├── ModelLibrary           # Modelos de dados (entidades)
├── RepositoryLibrary      # Simulação de persistência (List)
├── ControllerLibrary      # Lógica de negócio e validações

Cada camada possui responsabilidade única, promovendo coesão e reutilização.

---

## Regras de Negócio

- Um alerta só pode ser gerado se a pessoa e a falha existirem.
- Pessoas devem ser corretamente classificadas (idoso, deficiência, pobreza).
- Somente operadores autenticados podem acessar o sistema.
- Erros de entrada são tratados com validações e mensagens claras.

---

## Como Executar

1. Clone este repositório:
   ```bash
   git clone https://github.com/seu-usuario/RescueAlert.git

	2.	Abra a solução no Visual Studio 2022 ou superior.
	3.	Defina o projeto RescueAlert.ConsoleApp como Startup Project.
	4.	Execute a aplicação (Ctrl + F5).
	5.	Use as credenciais abaixo para fazer login e acessar o sistema.

⸻

Credenciais de Acesso

Estas são as credenciais padrão embutidas na aplicação para fins de demonstração:

Usuário: admin
Senha: admin123

Você pode alterar ou adicionar mais usuários diretamente no código, na classe UsuarioRepository.

⸻

Requisitos
	•	.NET 6 SDK
	•	Visual Studio 2022
	•	Sistema operacional Windows (preferencialmente)

⸻

Estrutura de Pastas

RescueAlert/
├── ConsoleApp/
│   └── Program.cs         # Menu e controle da aplicação
│   └── log_eventos.txt    # Logs de atividades do sistema
├── ControllerLibrary/
│   └── Controllers/       # Regras de negócio e validações
├── ModelLibrary/
│   └── Models/            # Entidades: Pessoa, Falha, Alerta
├── RepositoryLibrary/
│   └── Repositories/      # Simulação de banco (List<T>)
├── README.md


⸻

Tecnologias Utilizadas

Tecnologia	Finalidade
C# / .NET 6	Lógica da aplicação
ConsoleApp	Interface de linha de comando
Bibliotecas de Classes	Modularização e separação de camadas
List	Simulação de persistência na memória
File.AppendAllText	Registro de logs


⸻

Conteúdo Acadêmico Aplicado
	•	Programação Orientada a Objetos (POO)
	•	Encapsulamento e herança
	•	Arquitetura em camadas
	•	Tratamento de exceções (try-catch)
	•	Validação de entrada
	•	Boas práticas de código limpo

⸻

Autores

Projeto desenvolvido por:
	•	ANNY CAROLINA ANDRADE DIAS - RM:98295 
	•	HENRIQUE LIMA - RM:551528
	•	SOFIA AMORIM COUTINHO - RM:552534 


⸻

