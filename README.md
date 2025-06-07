
# RescueAlert

**RescueAlert** é um sistema de monitoramento de falhas de energia com impacto cibernético, voltado ao atendimento de populações vulneráveis em situações emergenciais, como apagões e desastres naturais. A aplicação foi desenvolvida em C# utilizando arquitetura em camadas e bibliotecas de classes.

---
## Demonstração do Projeto
Assista ao vídeo de apresentação do sistema no YouTube:

[![Assista no YouTube](https://img.shields.io/badge/Ver%20no-YouTube-red?logo=youtube)](https://www.youtube.com/watch?v=vv2iH_Ovv6I)

---

##  Finalidade do Sistema

O objetivo do RescueAlert é facilitar a comunicação e organização em cenários críticos, garantindo que pessoas em risco — como idosos, pessoas com deficiência e em situação de pobreza — possam ser localizadas e associadas a alertas de emergência durante falhas de energia.

O sistema permite:

- Registrar falhas de energia por região.
- Cadastrar pessoas vulneráveis com base em sua condição.
- Gerar alertas relacionando pessoas e falhas específicas.
- Acompanhar relatórios de status dos alertas.
- Controlar o acesso via login obrigatório.
- Registrar todos os eventos em arquivos de log.

---

##  Instruções de Execução

### Requisitos:
- .NET 6 SDK ou superior
- Visual Studio 2022 ou superior (recomendado)
- Sistema Operacional: Windows

### Passos para rodar a aplicação:

1. Clone o repositório:
```bash
git clone https://github.com/seu-usuario/RescueAlert.git
```

2. Abra a solução `RescueAlert.sln` no Visual Studio.

3. Defina o projeto `RescueAlert.ConsoleApp` como *Startup Project*.

4. Execute a aplicação (Ctrl + F5).

5. Faça login com as seguintes credenciais:
```
Usuário: admin
Senha: 1234
```

---

##  Dependências

O projeto foi desenvolvido apenas com bibliotecas padrão do .NET. Não há dependências externas a serem instaladas.

---

##  Estrutura de Pastas

```
RescueAlert/
├── ConsoleApp/                 # Interface do usuário via console
│   └── Program.cs              # Menu principal da aplicação
│   └── log_eventos.txt         # Arquivo de logs gerado automaticamente
│
├── ControllerLibrary/          # Camada de lógica e validações
│   └── Controllers/
│       └── PessoaController.cs
│       └── FalhaController.cs
│       └── AlertaController.cs
│       └── UsuarioController.cs
│
├── ModelLibrary/               # Modelos de dados
│   └── Models/
│       └── Pessoa.cs
│       └── Falha.cs
│       └── Alerta.cs
│       └── Usuario.cs
│
├── RepositoryLibrary/          # Simulação de persistência
│   └── Repositories/
│       └── PessoaRepository.cs
│       └── FalhaRepository.cs
│       └── AlertaRepository.cs
│       └── UsuarioRepository.cs
│
├── RescueAlert.sln             # Solução Visual Studio
├── README.md
```

---

##  Observações Finais

Este projeto é acadêmico e não realiza persistência real em banco de dados. Toda a simulação é feita com `List<T>` em memória. A arquitetura em camadas foi aplicada para promover organização, reutilização e escalabilidade do código.

O arquivo `log_eventos.txt` registra todas as ações executadas, facilitando a auditoria do sistema em tempo de execução.

---




## Autores

Projeto desenvolvido por:
- ANNY CAROLINA ANDRADE DIAS - RM:98295 
- HENRIQUE LIMA - RM:551528
- SOFIA AMORIM COUTINHO - RM:552534 


---


