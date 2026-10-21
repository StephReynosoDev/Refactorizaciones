public class Configuracion
{
    private static Configuracion _instancia;

    public string NombreApp {get; set;}
    public string Version {get; set;}

    private Configuracion()
    {
        
    }

    public static Configuracion ObtenerInstancia()
    {
        if (_instancia == null)
        {
            _instancia = new Configuracion();

        }
        return _instancia;
    
        }
        public void MostrarInfo()
    {
        Console.WriteLine($"El Nombre de la App es: {NombreApp}");
        Console.WriteLine($"La Version es: {Version}");
    }
    }
