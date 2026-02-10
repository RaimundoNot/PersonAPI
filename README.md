# Person API (Minimal API em .NET 10)

## 📌 Escopo inicial

Este projeto é um CRUD de API Minimal em desenvolvimento, utilizando .NET 10 com Entity Framework Core e SQLite.
Atualmente já está rodando com Swagger configurado, permitindo visualizar e testar os endpoints.


## 🚀 Funcionalidades implementadas
- Endpoint GET /person que retorna uma instância da classe PersonModels.
- Endpoint POST /person que recebe um PersonRequest e persiste no banco de dados SQLite.

## 📁 Estrutura

## - Models
 - PersonModels: representa uma pessoa com propriedades:
 - Id (Guid): gerado automaticamente para garantir unicidade.
 - O uso de Guid evita colisões e é útil em cenários distribuídos, onde IDs sequenciais poderiam gerar conflitos.
 - Name (string): nome da pessoa.
 - init no Id: garante que o valor só pode ser definido na inicialização, mantendo imutabilidade após criado.
 - PersonRequest: definido como um record, simplificando a criação de tipos imutáveis e ideais para representar dados de entrada.

## - Routes
- PersonRoute: define o grupo de rotas /person, incluindo:
- GET /person
- POST /person (com persistência no banco via EF Core).

## - Data
- PersonContext: contexto do Entity Framework Core configurado para usar SQLite (person.sqlite).

## - Migrations
- Pasta gerada automaticamente pelo comando dotnet ef migrations add, contendo o histórico de alterações do modelo de dados.

# 🗄️ Banco de Dados

## - Banco de dados: SQLite
- Visualização: extensão de Database do VSCode para SQLite, permitindo acompanhar em tempo real as alterações no banco.


## 📖 Status- Projeto em desenvolvimento.
- Projeto em desenvolvimento.
- Swagger já está configurado e funcionando para documentação e testes dos endpoints.
- CRUD em construção: atualmente implementados Read e Create.
- Próximos passos: implementar Update e Delete, além de adicionar validações e tratamento de erros.