# dioflix
Desafio az204 | Dioflix | Azure Functions + CosmosDB



---

## Projeto de Aplicação para Gerenciamento de Banco de Dados de Filmes

Este projeto é uma aplicação de exemplo que utiliza **Azure Functions** para gerenciar um banco de dados de filmes. A aplicação é desenvolvida em **.NET 8** e utiliza o **Azure Cosmos DB** para o armazenamento de dados.

### Tecnologias Utilizadas

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Azure Functions Core Tools](https://docs.microsoft.com/azure/azure-functions/functions-run-local)
- [Azure Cosmos DB](https://azure.microsoft.com/services/cosmos-db/)

## Configuração

1. Clone o repositório para sua máquina local:
   
 ```sh
   git clone https://github.com/seu-usuario/seu-repositorio.git
   cd seu-repositorio
   ```

2. Configure as variáveis de ambiente no arquivo `local.settings.json`:
```JSON
{
    "IsEncrypted": false,
    "Values": {
        "AzureWebJobsStorage": "UseDevelopmentStorage=true",
        "FUNCTIONS_WORKER_RUNTIME": "dotnet-isolated",
        "CosmoDBConnection": "AccountEndpoint=https://<SEU_COSMOS_DB_ENDPOINT>;AccountKey=<SEU_COSMOS_DB_KEY>;"
    },
    "Host": {
        "CORS": "*"
    }
}
```



3. Certifique-se de que o Azure Cosmos DB está configurado corretamente e que as credenciais no `local.settings.json` estão corretas.

## Como executar o Projeto

1. Inicie o Azure Functions Core Tools:
   
```sh
func start
```

2. Acesse a URL fornecida pelo Azure Functions Core Tools para interagir com as funções.

## Estrutura do Projeto

- `fnGetAllMovies`: Contém a função para obter todos os filmes do banco de dados Cosmos DB.
- `local.settings.json`: Arquivo de configuração local para o Azure Functions.

## Funcionalidades

### Obter Todos os Filmes

Esta função recupera todos os filmes armazenados no Azure Cosmos DB.

- **Endpoint:** `GET /api/GetAllMovies`
- **Descrição:** Retorna uma lista de todos os filmes no banco de dados.

### Para adicionar um Novo Filme

Esta função adiciona um novo filme ao Azure Cosmos DB.

- **Endpoint:** `POST /api/AddMovie`
- **Descrição:** Adiciona um novo filme ao banco de dados.
- **Corpo da Requisição:**

```JSON
{
    "id": "string",
    "title": "string",
    "director": "string",
    "releaseYear": "int"
}
```



### Para atualizar um Filme

Esta função atualiza um filme existente no Azure Cosmos DB.

- **Endpoint:** `PUT /api/UpdateMovie`
- **Descrição:** Atualiza um filme existente no banco de dados.
- **Corpo da Requisição:**
```JSON
{
    "id": "string",
    "title": "string",
    "director": "string",
    "releaseYear": "int"
}
```



### Para deletar um Filme

Esta função deleta um filme do Azure Cosmos DB.

- **Endpoint:** `DELETE /api/DeleteMovie`
- **Descrição:** Deleta um filme do banco de dados.
- **Parâmetros da Requisição:**
```JSON
{
    "id": "string"
}
```



