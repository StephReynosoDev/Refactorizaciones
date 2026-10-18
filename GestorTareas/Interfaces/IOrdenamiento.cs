using GestorTareas.Models;

namespace GestorTareas.Strategy;

public interface IOrdenamiento
{
    List<Tarea> Ordenar(List<Tarea> tareas);
}