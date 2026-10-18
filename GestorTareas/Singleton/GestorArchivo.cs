using System.Text.Json;
using GestorTareas.Models;

namespace GestorTareas.Singleton;

public class GestorArchivo
{
    private static GestorArchivo _instancia;
    private const string NombreArchivo = "tasks.json";
    private readonly JsonSerializerOptions _opciones = new JsonSerializerOptions { WriteIndented = true };

    private GestorArchivo()
    {
        if (!File.Exists(NombreArchivo))
            File.WriteAllText(NombreArchivo, "[]");
    }

    public static GestorArchivo ObtenerInstancia()
    {
        if (_instancia == null)
            _instancia = new GestorArchivo();
        return _instancia;
    }

    public List<Tarea> LeerTareas()
    {
        string contenido = File.ReadAllText(NombreArchivo);
        return JsonSerializer.Deserialize<List<Tarea>>(contenido) ?? new List<Tarea>();
    }

    public void GuardarTareas(List<Tarea> tareas)
    {
        string json = JsonSerializer.Serialize(tareas, _opciones);
        File.WriteAllText(NombreArchivo, json);
    }
}