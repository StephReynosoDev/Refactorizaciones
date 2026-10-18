using System.Text.Json;

namespace GestorTareas.Middleware;

public class ApiKeyMiddleware
{
    private readonly RequestDelegate _next;
    private const string ApiKey = "PII-2026";

    public ApiKeyMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        if (context.Request.Path.StartsWithSegments("/tasks"))
        {
            string key = context.Request.Headers["X-Api-Key"].FirstOrDefault();
            if (key != ApiKey)
            {
                context.Response.ContentType = "application/json";
                context.Response.StatusCode = 401;
                var error = new
                {
                    codigo = 401,
                    mensaje = "API Key invalida o ausente.",
                    detalles = new List<string>(),
                    requestId = context.Items["RequestId"]?.ToString()
                };
                await context.Response.WriteAsync(JsonSerializer.Serialize(error));
                return;
            }
        }
        await _next(context);
    }
}