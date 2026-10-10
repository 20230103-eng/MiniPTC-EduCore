# eduCore

## Integrantes

- Pérez Echegoyen, Marcos Adrián
- Ramírez Flores, Rafael Andrés
- Zometa Escobar, Diego Alexander

Desarrollo de Software B1 · Instituto Técnico Ricaldone

## 1. Configurar el servidor SQL

En `Vista/App.config` cambia el valor de `ServidorSQL` por el nombre de tu instancia de SQL Server:

```xml
<add key="ServidorSQL" value=".\MSSQLSERVER01" />
```

Ejemplos: `.\SQLEXPRESS`, `.\MSSQLSERVER01`, `localhost`.

## 2. Crear la base de datos

En SQL Server Management Studio ejecuta, en este orden:

1. `SQL/Estructura.sql`
2. `SQL/Insertar.sql`

Se crea la base de datos `DbGestionAcademica` con los datos de prueba.

> Si `DbGestionAcademica` ya existe, elimínala antes de ejecutar los scripts.

## 3. Ejecutar

Abre `eduCore.sln` en Visual Studio y ejecuta el proyecto `Vista`.

## Usuarios de prueba

| Rol           | Usuario | Contraseña    |
|---------------|---------|---------------|
| Administrador | admin01 | Admin123      |
| Profesor      | prof01  | Profesor123   |
| Estudiante    | est01   | Estudiante123 |
