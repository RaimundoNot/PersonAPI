# Person API (Minimal API em .NET 10)

## 📌 Escopo inicial

Este projeto é um CRUD de API Minimal, utilizando .NET 10 com Entity Framework Core e SQLite.
Atualmente já está rodando com Swagger configurado, permitindo visualizar e testar os endpoints.


## 🚀 Funcionalidades implementadas
- Create: POST /person
Recebe um PersonRequest e persiste no banco de dados SQLite.
- Read: GET /person
Retorna todas as pessoas cadastradas.
- Update: PUT /person/{id}
Atualiza o nome de uma pessoa existente utilizando o método ChangeName.
- Delete: DELETE /person/{id}
Implementado como Soft Delete, utilizando o método SetInactive.
(Em vez de excluir definitivamente a linha do banco, o registro é marcado como "desativado", preservando o histórico.)

## 📁 Estrutura

## - Models
 - PersonModels: representa uma pessoa com propriedades:
 - Id (Guid): gerado automaticamente para garantir unicidade.
 - O uso de Guid evita colisões e é útil em cenários distribuídos, onde IDs sequenciais poderiam gerar conflitos.
 - Name (string): nome da pessoa.
 - ChangeName(string name): atualiza o nome.
 - SetInactive(): marca a pessoa como inativa, implementando o conceito de Soft Delete.
 - init no Id: garante que o valor só pode ser definido na inicialização, mantendo imutabilidade após criado.
 - PersonRequest: definido como um record, simplificando a criação de tipos imutáveis e ideais para representar dados de entrada.

## - Routes
- PersonRoute: define o grupo de rotas /person, incluindo:
- POST /person (com persistência no banco via EF Core).
- GET /person (retorna todas as pessoas ativas).
- PUT /person/{id} (atualiza o nome de uma pessoa existente).
- DELETE /person/{id} (marca a pessoa como inativa, implementando Soft Delete).

## - Data
- PersonContext: contexto do Entity Framework Core configurado para usar SQLite (person.sqlite).

## - Migrations
- Pasta gerada automaticamente pelo comando dotnet ef migrations add, contendo o histórico de alterações do modelo de dados.

<<<<<<< HEAD
# 🗄️ Banco de Dados

SQLite
=======
# 🗄️ Banco de Dados - SQLite
>>>>>>> c6d0198ecdc7e03bbd78eaba259b8aab88af4d53
- Visualização: extensão de Database do VSCode para SQLite, permitindo acompanhar em tempo real as alterações no banco.

# 🔗 Documentação
A API está documentada com Swagger/OpenAPI.

- Interface interativa: [Swagger UI](https://localhost:5121/swagger)  
- Especificação JSON: [OpenAPI](http://localhost:5121/swagger/v1/swagger.json)

> Execute `dotnet run` e acesse os links acima para visualizar e testar os endpoints.

# 📖 Status 
Projeto Finalizado.
- Swagger configurado e funcionando para documentação e testes dos endpoints.
- CRUD em completo.
