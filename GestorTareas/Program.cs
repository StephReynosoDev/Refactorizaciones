using GestorTareas.Interfaces;
using GestorTareas.Middleware;
using GestorTareas.Services;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers()
    .ConfigureApiBehaviorOptions(options =>
    {
        options.SuppressModelStateInvalidFilter = true;
    });


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ITarea, TareaService>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseMiddleware<ErrorMiddleware>();
app.UseMiddleware<RequestIdMiddleware>();
app.UseMiddleware<RegistroMiddleware>();
app.UseMiddleware<ApiKeyMiddleware>();

app.MapControllers();
app.Run();