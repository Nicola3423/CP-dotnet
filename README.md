# API de Gerenciamento de Brinquedos 🪀

## Descrição
API CRUD para gestão de brinquedos infantis desenvolvida em .NET com Entity Framework Core.

## RM553991

## Tecnologias
- .NET 7
- Entity Framework Core
- Swagger/OpenAPI

## Configuração

### Pré-requisitos
- .NET 7 SDK

### Passos para Executar
1. Clonar o repositório
```bash
git clone https://github.com/seu-usuario/api-brinquedos.git
cd api-brinquedos
```

2. Restaurar dependências
```bash
dotnet restore
```

3. Executar a aplicação
```bash
dotnet run
```

## Endpoints

| Método | Endpoint                 | Ação                           |
|--------|--------------------------|--------------------------------|
| GET    | `/api/brinquedos`        | Listar brinquedos              |
| POST   | `/api/brinquedos`        | Cadastrar brinquedo            |
| PUT    | `/api/brinquedos/{id}`   | Atualizar brinquedo            |
| DELETE | `/api/brinquedos/{id}`   | Remover brinquedo              |

## Exemplos de Uso

### Listar Brinquedos (GET)
```http
GET /api/brinquedos
```

### Atualizar Brinquedo (PUT)
```http
PUT /api/brinquedos/1
Content-Type: application/json

{
    "preco": 129.90
}
```

### Cadastrar Brinquedo (POST)
```json
{
    "nome_brinquedo": "Quebra-Cabeça Gigante",
    "tipo_brinquedo": "Educativo",
    "classificacao": "6+",
    "tamanho": "Grande",
    "preco": 149.90
}
```

### Remover Brinquedo (DELETE)
```http
DELETE /api/brinquedos/1
```

## Documentação
Acessar Swagger: `http://localhost:5000/swagger`

## Licença
Projeto para fins acadêmicos - Todos os direitos reservados.
