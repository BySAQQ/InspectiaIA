# InspectiaIA

InspectiaIA es una API minimalista desarrollada en ASP.NET Core (.NET 9) para la inspecci�n de software utilizando IA (simulada). Permite analizar software enviando una solicitud HTTP y obteniendo una respuesta generada autom�ticamente.

## Requisitos

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- Git

## Instalaci�n

1. **Clona el repositorio:**{
   ```bash
   git clone}

2. **Restaura las dependencias:**
   ```bash
   cd InspectiaIA
   dotnet restore
   ```
3. **Compila el proyecto:**
   ```bash
   dotnet build
   ```
4. **Ejecuta la aplicaci�n:**
   ```bash
   dotnet run
   ```
   
## Endpoints

### POST `/analizar`

Analiza un software enviando un JSON con el nombre y la descripci�n.

**Ejemplo de solicitud:**
```json
{
  "nombre": "MiSoftware",
  "descripcion": "Este es un software de ejemplo para inspecci�n."
}
```
**Ejemplo de respuesta:**
```json
{
  "resultado": "El software 'MiSoftware' ha sido analizado exitosamente. Se han encontrado 0 problemas."
}
```


## Librer�as utilizadas

- `Microsoft.AspNetCore.OpenApi`
- `Microsoft.AspNetCore.Mvc`

Estas dependencias se restauran autom�ticamente con `dotnet restore`.

## Documentaci�n OpenAPI


## Notas

--