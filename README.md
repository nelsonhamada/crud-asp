# Crud Clientes ASP.Net

API desenvolvida com ASP.net onde é possível cadastrar, ver, editar e deletar clientes em um banco de dados simulado.
Aplicação conta com testes de integração contínua via GitHub Actions.

<details>
<summary><strong>Para rodar localmente</strong></summary><br/>
  
Clone esse repositório:
```
git clone git@github.com:nelsonhamada/crud-asp.git
```

Entre no diretório `src/` e instale as dependências:
```
cd crud-asp/src/CustomerCrud && dotnet restore
```

Para rodar a aplicação é necessário estar no diretório `CustomerCrud/` e executar:
```
dotnet run
```

Para rodar os testes é necessário estar no diretório `CustomerCrud.Test/` e executar:
```
dotnet test
```
</details>

## Rotas

<details>
<summary><strong>POST</strong></summary>
Para o endpoit POST `/customers` o body da requisição é:<br />

{<br />
  "name": "Nelson",<br />
  "cpf": "092891378" <br />
}<br />

</details>
<details>
<summary><strong>GET /{id}, DELETE</strong></summary><br/>
Nos endpoints DELETE e GET a rota é /customers/{id}
</details>


Repositório criado com intuito de estudos iniciais em C# ASP.NET
Atenciosamente,
Nelson Hamada.
[Linkedin](https://www.linkedin.com/in/nelson-hamada/)
