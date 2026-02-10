# Person API (Minimal API em .NET 10)

 📌 Escopo inicial

## Este projeto é um CRUD de API Minimal em desenvolvimento, utilizando .NET 10. Atualmente já está rodando com Swagger configurado, permitindo visualizar e testar os endpoints.

# 🚀 Funcionalidades implementadas
## - Endpoint GET /person que retorna uma instância da classe PersonModels.

# 📁 Estrutura

## - Models
 - PersonModels: representa uma pessoa com propriedades:
 - Id (Guid): gerado automaticamente para garantir unicidade.
 - O uso de Guid evita colisões e é útil em cenários distribuídos, onde IDs sequenciais poderiam gerar conflitos.
 - Name (string): nome da pessoa.
 - init no Id: garante que o valor só pode ser definido na inicialização, mantendo imutabilidade após criado.

# - Routes
## - PersonRoute: define o endpoint /person.

# 📖 Status- Projeto em desenvolvimento.
## - Swagger já está configurado e funcionando para documentação e testes dos endpoints.
