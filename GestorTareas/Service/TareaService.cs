using GestorTareas.Interfaces;
using GestorTareas.Models;
using GestorTareas.Singleton;

namespace GestorTareas.Services;

public class TareaService : ITarea
{
    private readonly GestorArchivo _gestor = GestorArchivo.ObtenerInstancia();

    public List<Tarea> GetTareas(string estado)
    {
        var tareas = _gestor.LeerTareas();

        if (string.IsNullOrEmpty(estado))
            return tareas;

        if (estado.ToLower() == "pendiente")
            return tareas.Where(t => t.Estado == EstadoTarea.Pendiente).ToList();

        if (estado.ToLower() == "completada")
            return tareas.Where(t => t.Estado == EstadoTarea.Completada).ToList();

        throw new ArgumentException("Estado no reconocido.");
    }

    public Tarea GetPorId(Guid id)
    {
        return _gestor.LeerTareas().FirstOrDefault(t => t.Id == id);
    }

    public Tarea Crear(Tarea tarea)
    {
        var tareas = _gestor.LeerTareas();
        tarea.Id = Guid.NewGuid();
        tarea.FechaCreacion = DateTime.Now;
        tarea.Estado = EstadoTarea.Pendiente;
        tareas.Add(tarea);
        _gestor.GuardarTareas(tareas);
        return tarea;
    }

    public Tarea Actualizar(Guid id, Tarea tarea)
    {
        var tareas = _gestor.LeerTareas();
        var existente = tareas.FirstOrDefault(t => t.Id == id);
        if (existente == null) return null;
        existente.Titulo = tarea.Titulo;
        existente.Descripcion = tarea.Descripcion;
        existente.FechaLimite = tarea.FechaLimite;
        _gestor.GuardarTareas(tareas);
        return existente;
    }

    public Tarea Completar(Guid id)
    {
        var tareas = _gestor.LeerTareas();
        var existente = tareas.FirstOrDefault(t => t.Id == id);
        if (existente == null) return null;
        if (existente.Estado == EstadoTarea.Completada)
            throw new InvalidOperationException("La tarea ya estaba completada.");
        existente.Estado = EstadoTarea.Completada;
        _gestor.GuardarTareas(tareas);
        return existente;
    }

    public bool Eliminar(Guid id)
    {
        var tareas = _gestor.LeerTareas();
        var existente = tareas.FirstOrDefault(t => t.Id == id);
        if (existente == null) return false;
        tareas.Remove(existente);
        _gestor.GuardarTareas(tareas);
        return true;
    }
}