using GestorTareas.Models;

namespace GestorTareas.Interfaces;

public interface ITarea
{
    List<Tarea> GetTareas(string estado);
    Tarea GetPorId(Guid id);
    Tarea Crear(Tarea tarea);
    Tarea Actualizar(Guid id, Tarea tarea);
    Tarea Completar(Guid id);
    bool Eliminar(Guid id);
}