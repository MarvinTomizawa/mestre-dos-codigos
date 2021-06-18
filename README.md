# Mestre dos códigos

# Criando projeto
> dotnet new sln
> dotnet new console -n ConsoleApp
> dotnet sln add ConsoleApp

# Rodando o projeto

# Perguntas Teóricas:
## 1 - Em quais linguagens o C# foi inspirado?
Foi visto como uma atualização de C/C++ e teve alta inspiração na linguagem Java já que na época ele já possuia implementado parte das metas de design declaradas pelo ECMA que o C# buscava alcançar.<br>

## 2 - Inicialmente o C# foi criado para qual finalidade?
Inicialmente foi utilizado para ser uma linguagem simples e moderna, de propósito geral, Orientada a Objetos e fortemente tipada com muitas extensões adicionais para permitir também uma abordagem mais orientada a componentes.

Como dito no exercício anterior, ele buscava alcançar alguns objetivos de design definidos pelo ECMA.
Alguns design goals:
- Simples, Moderna e Para uso geral
- Orientada a Objetos
- Fortemente tipada
- Garbage collection automatica
- Suporte para internacionalização
- Adaptabilidade para os que ja estejam familiarizados com C/C++

## 3 - Quais os principais motivos para a Microsoft ter migrado para o Core?
Maior utilização containers, maior liberdade para desenvolvimento multi-plataforma, configurações por CLI, escolhas de soluções não dependentes de UI como micro-serviços e necessidades de escalonamento.

## 4 - Cite as principais diferenças entre .Net Full Framework e .Net Core.
.NET Framework
- Mais simples
- Windows e Web Applications
- Aplicações centradas na interface do usuário
- Maior facilidade na utilização de API's para mexer em recursos do windows
 
.NET CORE
- Possui uma curva de aprendizagem
- Maior performance, sem UI
- Maior uso de linha de comando
- Maior aproveitamento de soluções não dependentes de UI e escalonamento
- open-source and cross-platform framework 