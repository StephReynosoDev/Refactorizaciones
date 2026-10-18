using GestorTareas.Factory;
using GestorTareas.Interfaces;
using GestorTareas.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestorTareas.Controllers;

[ApiController]
[Route("tasks")]
public class TareaController : ControllerBase
{
    private readonly ITarea _service;

    public TareaController(ITarea service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult GetTareas([FromQuery] string? estado, [FromQuery] string? orden)
    {
        var tareas = _service.GetTareas(estado);
        var estrategia = OrdenamientoFactory.ObtenerEstrategia(orden);
        return Ok(estrategia.Ordenar(tareas));
    }

    [HttpGet("{id}")]
    public IActionResult GetPorId(Guid id)
    {
        var tarea = _service.GetPorId(id);
        if (tarea == null) return NotFound(new { codigo = 404, mensaje = "Tarea no encontrada bro.", detalles = new List<string>(), requestId = HttpContext.Items["RequestId"]?.ToString() });
        return Ok(tarea);
    }

    [HttpPost]
    public IActionResult Crear([FromBody] Tarea tarea)
    {
        if (string.IsNullOrEmpty(tarea.Titulo) || tarea.FechaLimite < DateTime.Now)
            return BadRequest(new { codigo = 400, mensaje = "Titulo vacio o FechaLimite invalida.", detalles = new List<string>(), requestId = HttpContext.Items["RequestId"]?.ToString() });

        var creada = _service.Crear(tarea);
        return Created($"/tasks/{creada.Id}", creada);
    }

    [HttpPut("{id}")]
    public IActionResult Actualizar(Guid id, [FromBody] Tarea tarea)
    {
        var existente = _service.GetPorId(id);
        if (existente == null) return NotFound(new { codigo = 404, mensaje = "Tarea no encontrada.", detalles = new List<string>(), requestId = HttpContext.Items["RequestId"]?.ToString() });
        if (tarea.FechaCreacion != default && tarea.FechaCreacion != existente.FechaCreacion)
            return BadRequest(new { codigo = 400, mensaje = "No se puede modificar FechaCreacion.", detalles = new List<string>(), requestId = HttpContext.Items["RequestId"]?.ToString() });
        var actualizada = _service.Actualizar(id, tarea);
        return Ok(actualizada);
    }

    [HttpPatch("{id}/complete")]
    public IActionResult Completar(Guid id)
    {
        var existente = _service.GetPorId(id);
        if (existente == null) return NotFound(new { codigo = 404, mensaje = "Tarea no encontrada bro.", detalles = new List<string>(), requestId = HttpContext.Items["RequestId"]?.ToString() });
        var completada = _service.Completar(id);
        return Ok(completada);
    }

    [HttpDelete("{id}")]
    public IActionResult Eliminar(Guid id)
    {
        var resultado = _service.Eliminar(id);
        if (!resultado) return NotFound(new { codigo = 404, mensaje = "Tarea no encontrada mio.", detalles = new List<string>(), requestId = HttpContext.Items["RequestId"]?.ToString() });
        return NoContent();
    }

    [HttpGet("/health")]
    public IActionResult Health()
    {
        return Ok("OK");
    }
}