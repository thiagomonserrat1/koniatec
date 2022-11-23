# Konia Tech

## Descrição do projeto

Aplicação console para o processo seletivo da Konia Tech em C# com .NET 6.0

## Acesso rápido

- [Konia Tech](#konia-tech)
  - [Descrição do projeto](#descrição-do-projeto)
  - [Acesso rápido](#acesso-rápido)
  - [1.0 Iniciar projeto com PostgreSQL](#10-iniciar-projeto-com-postgresql)
    - [Rode as Migrations com:](#rode-as-migrations-com)
        - [OU](#ou)
    - [Rode a aplicação com NUGET ou:](#rode-a-aplicação-com-nuget-ou)
  - [2.0 Iniciar projeto com ServerSQL](#20-iniciar-projeto-com-serversql)
    - [Remova as antigas Migrations com:](#remova-as-antigas-migrations-com)
        - [OU](#ou-1)
    - [Cria as novas Migrations com:](#cria-as-novas-migrations-com)
        - [OU](#ou-2)
    - [Rode sua Migration e suba seu DB com:](#rode-sua-migration-e-suba-seu-db-com)
        - [OU](#ou-3)
    - [Rode a aplicação com NUGET ou:](#rode-a-aplicação-com-nuget-ou-1)

## 1.0 Iniciar projeto com PostgreSQL

### Rode as Migrations com:

```
CLI: dotnet ef database update
```

##### OU

```
PM: Update-Database
```

### Rode a aplicação com NUGET ou:

```
CLI: dotnet run
```

## 2.0 Iniciar projeto com ServerSQL

### Remova as antigas Migrations com:

```
CLI: dotnet ef migrations remove
```

##### OU

```
PM: remove-migration
```

### Cria as novas Migrations com:

```
CLI: dotnet ef migrations add MyFirstMigration
```

##### OU

```
PM: add-migration MyFirstMigration
```

### Rode sua Migration e suba seu DB com:

```
CLI: dotnet ef database update
```

##### OU

```
PM: Update-Database
```

### Rode a aplicação com NUGET ou:

```
CLI: dotnet run
```
