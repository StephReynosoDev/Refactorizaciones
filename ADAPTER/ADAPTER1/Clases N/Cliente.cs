public class Cliente
{


    private IGeneradorReporte _adaptador;

    public Cliente(IGeneradorReporte adaptador)
    {
        _adaptador = adaptador;
    }

    public void ExportarReporte(string contenido, string nombreArchivo)
    {



        string resultado = _adaptador.GenerarReporte(contenido, nombreArchivo );
        Console.WriteLine($"[Cliente] {resultado}");
    }
}
