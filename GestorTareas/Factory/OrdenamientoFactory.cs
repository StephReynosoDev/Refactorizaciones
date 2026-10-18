using GestorTareas.Strategy;

namespace GestorTareas.Factory;

public class OrdenamientoFactory
{
    private static readonly Dictionary<string, IOrdenamiento> _estrategias = new()
    {
        { "fechaLimite", new FechaLimiteOrden() },
        { "creacion", new CreacionOrden() },
        { "urgencia", new UrgenciaOrden() }
    };

    public static IOrdenamiento ObtenerEstrategia(string orden)
    {
        if (string.IsNullOrEmpty(orden))
            return new CreacionOrden();

        if (!_estrategias.ContainsKey(orden))
            throw new ArgumentException("Criterio de orden no reconocido.");

        return _estrategias[orden];
    }
}