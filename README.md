# somnguard-backend

Base en C# / .NET para un monolito modular con arquitectura limpia / hexagonal.

## Estructura

- `src/` contiene el proyecto principal de la API.
- `src/modules/` agrupa los módulos por dominio.
- `src/shared/` concentra componentes compartidos entre módulos.
- `tests/` reserva espacio para pruebas unitarias e integración.

## Arranque local

```bash
dotnet run --project src/somnguard-backend.csproj
```

## Contenedores

```bash
docker compose up -d
```