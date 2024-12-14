# Dependências do Projeto


#### Provedor de banco de dados
Este provedor de banco de dados permite que o Entity Framework Core seja usado com o Microsoft SQL Server (incluindo o Banco de Dados SQL do Azure). O provedor é mantido como parte do Projeto do Entity Framework Core.

[Documentação oficial](https://learn.microsoft.com/pt-br/ef/core/providers/sql-server/?tabs=dotnet-core-cli)

> Microsoft.EntityFrameworkCore.SqlServer

#### Migrações e Modelos

O pacote `Design` fornece funcionalidades que auxiliam principalmente no design e geração de modelos e migrações.

[Documentação oficial](https://learn.microsoft.com/pt-br/ef/core/cli/services)

> Microsoft.EntityFrameworkCore.Design

#### Autenticação e Autorização
O pacote Microsoft.AspNetCore.Authentication.JwtBearer é utilizado em aplicativos ASP.NET Core para configurar a autenticação baseada em JWT (JSON Web Tokens). Ele fornece a funcionalidade necessária para autenticar requisições HTTP usando tokens JWT.

[Documentação no Nuget.org](https://www.nuget.org/packages/Microsoft.AspNetCore.Authentication.JwtBearer)

> Microsoft.AspNetCore.Authentication.JwtBearer