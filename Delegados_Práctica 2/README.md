# Delegados en C# - Desarrollo de Interfaces

Cada carpeta contiene un proyecto de consola independiente (Program.cs + .csproj).

## Cómo ejecutar un ejercicio

    cd "Ejercicio 1"
    dotnet run

(Repite cambiando el número de carpeta.)

## Notas

- El proyecto apunta a .NET 8 (`net8.0`). Si tienes otra versión instalada
  (por ejemplo .NET 9 o 10), cambia `<TargetFramework>` en el .csproj
  por `net9.0`, `net10.0`, etc.
- Como un delegado multicast solo devuelve el resultado del último método,
  en los ejercicios con varios métodos se recorre `GetInvocationList()`
  para obtener el resultado de cada uno.
