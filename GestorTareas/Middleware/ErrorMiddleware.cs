using System.Text.Json;

namespace GestorTareas.Middleware;

public class ErrorMiddleware
{
    private readonly RequestDelegate _next;

    public ErrorMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = ex is ArgumentException ? 400 :
                                          ex is InvalidOperationException ? 409 : 500;

            var error = new
            {
                codigo = context.Response.StatusCode,
                mensaje = ex is ArgumentException || ex is InvalidOperationException
                    ? ex.Message : "Error interno del servidor.",
                detalles = new List<string>(),
                requestId = context.Items["RequestId"]?.ToString()
            };

            await context.Response.WriteAsync(JsonSerializer.Serialize(error));
        }
    }
}