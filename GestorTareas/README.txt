# GestorTareas API

## Descripcion
API REST en .NET para gestionar tareas internas. Los datos se persisten en `tasks.json` sin base de datos ni ORM. Implemente los patrones Singleton, Strategy y Simple Factory, ademas de 4 middlewares propios.

---

## Como ejecutar

1. Abrir terminal en la carpeta del proyecto donde esta el `.csproj`
2. Restaurar dependencias y compilar:

```bash
dotnet build
```

3. Correr el servidor:

```bash
dotnet run
```

4. Abrir `pruebas.http` con la extension **REST Client** de VS Code y ejecutar cada peticion con **Send Request**

> El archivo `tasks.json` se crea automaticamente al arrancar si no existe.

---

## Contrato HTTP

| Operacion | Ruta | Exito | Errores |
|---|---|---|---|
| Crear tarea | POST /tasks | 201 + Location | 400 titulo vacio o fecha pasada |
| Listar tareas | GET /tasks | 200 | 400 estado no reconocido |
| Obtener por id | GET /tasks/{id} | 200 | 404 |
| Actualizar | PUT /tasks/{id} | 200 | 404, 400 si intenta cambiar FechaCreacion |
| Completar | PATCH /tasks/{id}/complete | 200 | 404, 409 si ya estaba completada |
| Eliminar | DELETE /tasks/{id} | 204 | 404 |
| Estado | GET /health | 200 | — |

Filtros disponibles en GET /tasks:
- `?estado=pendiente` o `?estado=completada`
- `?orden=fechaLimite`, `?orden=creacion`, `?orden=urgencia`
- Se pueden combinar: `?estado=pendiente&orden=urgencia`

---

## Middlewares propios

Implemente 4 middlewares como codigo propio, ninguno usa componentes del framework:

1. **ErrorMiddleware** — Intercepta cualquier excepcion no controlada y devuelve el formato uniforme de error con codigo 500. Ningun controlador tiene try/catch para producir respuestas de error.

2. **RequestIdMiddleware** — Asigna un identificador unico a cada peticion. Si el cliente envia `X-Request-Id` se respeta, si no se genera uno nuevo. Siempre aparece en el header de respuesta y en el campo `requestId` de los errores.

3. **RegistroMiddleware** — Registra en consola cada peticion con metodo HTTP, ruta, codigo de estado y duracion en milisegundos.

4. **ApiKeyMiddleware** — Todas las rutas bajo `/tasks` requieren el header `X-Api-Key: PII-2026`. Si falta o es incorrecta responde 401 con el formato uniforme. La ruta `/health` queda exenta.

### Formato uniforme de error

Toda respuesta de error sin excepcion devuelve:

```json
{
  "codigo": 400,
  "mensaje": "Descripcion del error.",
  "detalles": [],
  "requestId": "uuid-generado"
}
```

---

## Patrones de diseño

### Singleton — GestorArchivo
Todo acceso al archivo `tasks.json` pasa por la clase `GestorArchivo`. Esta clase tiene constructor privado e instancia estatica propia. La unicidad no se delega en `AddSingleton` del contenedor.

```csharp
private static GestorArchivo _instancia;
private GestorArchivo() { }
public static GestorArchivo ObtenerInstancia()
{
    if (_instancia == null)
        _instancia = new GestorArchivo();
    return _instancia;
}
```

### Strategy — Ordenamiento
Cada algoritmo de ordenamiento vive en su propia clase e implementa `IOrdenamiento`. El endpoint no contiene `if` ni `switch` para decidir el orden. Las clases no conocen el texto que llego por la URL.

- `CreacionOrden` — descendente por fecha de creacion
- `FechaLimiteOrden` — ascendente por fecha limite
- `UrgenciaOrden` — vencidas primero, luego pendientes por dias restantes, al final completadas

### Simple Factory — OrdenamientoFactory
La traduccion del texto recibido por URL al algoritmo concreto esta aislada en `OrdenamientoFactory`. Agregar un nuevo criterio solo requiere una clase nueva y un registro en el diccionario de la Factory, sin tocar el endpoint ni las clases existentes.

---

## Persistencia

- El archivo `tasks.json` es la unica fuente de verdad
- Se crea automaticamente si no existe al arrancar
- Si el archivo esta corrupto o tiene JSON invalido el servidor responde con el formato uniforme de error sin caerse
- Toda lectura y escritura pasa exclusivamente por `GestorArchivo`

---

## Supuestos tomados

- La API Key requerida es exactamente `PII-2026`
- Los campos `Id`, `FechaCreacion` y `Estado` son asignados por el servidor, no por el cliente
- `PUT` permite modificar `Titulo`, `Descripcion` y `FechaLimite`. Si el cuerpo incluye `FechaCreacion` con un valor diferente al almacenado responde 400
- Si `?orden=` tiene un valor no reconocido responde 400 con el formato uniforme
- Si `?orden=` esta ausente se aplica `creacion` por defecto