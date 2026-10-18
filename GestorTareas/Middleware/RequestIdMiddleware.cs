namespace GestorTareas.Middleware;

public class RequestIdMiddleware
{
    private readonly RequestDelegate _next;

    public RequestIdMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        string requestId = context.Request.Headers["X-Request-Id"].FirstOrDefault() ?? Guid.NewGuid().ToString();
        context.Items["RequestId"] = requestId;
        context.Response.Headers["X-Request-Id"] = requestId;
        await _next(context);
    }
}