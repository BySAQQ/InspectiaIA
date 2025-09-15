# InspectiaIA

InspectiaIA es una API minimalista desarrollada en ASP.NET Core (.NET 9) para la inspección de software utilizando IA (simulada). Permite analizar software enviando una solicitud HTTP y obteniendo una respuesta generada automáticamente.

## Requisitos

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- Git

## Instalación

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
4. **Ejecuta la aplicación:**
   ```bash
   dotnet run
   ```
   
## Endpoints

### POST `/analizar`

Analiza un software enviando un JSON con el nombre y la descripción.

**Ejemplo de solicitud:**
```json
{
  "nombre": "MiSoftware",
  "descripcion": "Este es un software de ejemplo para inspección."
}
```
**Ejemplo de respuesta:**
```json
{
  "resultado": "El software 'MiSoftware' ha sido analizado exitosamente. Se han encontrado 0 problemas."
}
```


## Librerías utilizadas

- `Microsoft.AspNetCore.OpenApi`
- `Microsoft.AspNetCore.Mvc`

Estas dependencias se restauran automáticamente con `dotnet restore`.

## Documentación OpenAPI


## Notas

--