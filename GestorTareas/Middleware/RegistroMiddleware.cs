namespace GestorTareas.Middleware;

public class RegistroMiddleware
{
    private readonly RequestDelegate _next;

    public RegistroMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        var inicio = DateTime.Now;
        await _next(context);
        var duracion = (DateTime.Now - inicio).TotalMilliseconds;
        Console.WriteLine($"{context.Request.Method} {context.Request.Path} {context.Response.StatusCode} {duracion}ms");
    }
}