
# Finshark

O presente projeto foi desenvolvido utilizando as melhores práticas para a construção de uma API cujo propósito é oferecer endpoints para o gerenciamento de ativos financeiros.


## Funcionalidades

- Adicionar ativo
- Listar ativos
- Listar um ativo específico
- Atualizar ativo
- Excluir um ativo


## Documentação da API

#### Retorna todos os itens

```http
  GET /api/stock
```

#### Retorna um item

```http
  GET /api/stock/${id}
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `id`      | `int` | **Obrigatório**. ID do ativo que deseja visualizar |



## Instalação

Para iniciarmos com a instalação do projeto lembre-se de ter em sua máquina instalado o .NET 8, para saber maiores informações acerca de sua instalação entre no site oficial [.NET 8](https://dotnet.microsoft.com/pt-br/download/dotnet/8.0)
   
Clone o repositório em sua máquina local, descompacte o arquivo e abra na sua IDE de preferência.         

Após, será necessário entrar no arquivo `appsettings.json` e configurar a sua conexão ao banco de dados SQL Server.   

Finalizada a configuração ao banco de dados precisamos agora rodar as nossas Migrations, para isso execute o seguinte comando em seu terminal.

```bash
  dotnet ef database update
```

Concluída essas etapas você poderá executar o projeto e ter acesso a página no Swagger para testar os endpoints da aplicação.

- **OBS:** Em caso de uso no Visual Studio Code execute o comando abaixo.

```bash
  dotnet watch run
```
  
## Stack utilizada

**Front-end:** React (Em desenvolvimento)

**Back-end:** C#, .NET 8, Web API, EF Core, MVC, SQL Server


