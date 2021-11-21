<h1 align="center">Judges DB</h1>
<p align="center">
    <img alt="C#" src="https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white" />
    <img alt="Blazor Webassembly" src="https://img.shields.io/badge/Blazor-5C2D91?style=for-the-badge&logo=blazor&logoColor=f9d129" />
    <img alt=".Net" src="https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white" />
    <img alt="Visual Studio" src="https://img.shields.io/badge/Visual%20Studio-5C2D91.svg?style=for-the-badge&logo=visual-studio&logoColor=white" />
    <img alt="MicrosoftSQLServer" src="https://img.shields.io/badge/Microsoft%20SQL%20Sever-CC2927?style=for-the-badge&logo=microsoft%20sql%20server&logoColor=white" />
</p>

---

A full stack .NET 5 web app with Blazor frontend and webapi backend, using Microsoft SQL Server and Entity Framework as the ORM to manage database through migrations.

## Instructions

- navigate to server directory:

```bash
cd BlazorApp/Server
```

- rename the appsettings file

```bash
mv example.appsettings.json appsettings.json
```

- open _appsettings.json_
- add SQL Server name, DB name, and login params to the connection string:

```json
{
  "ConnectionStrings": {
    "DefaultConnectionString": "Server=<your-db-server-name>; Initial Catalog=<your-db-name>; User ID=<user-name>; Password=<password>; Trusted_Connection=true;"
  },
...
}
```

- finally:

```bash
dotnet watch run
```
