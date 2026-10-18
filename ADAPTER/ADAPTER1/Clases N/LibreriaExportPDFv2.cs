// Incompatibilidad de secuencia/estado: requiere tres pasos en orden
class LibreriaExportPDFv2
{
    public void Abrir(string nombreArchivo)
    {
        Console.WriteLine($"[LibreriaExportPDFv2] Abriendo archivo: {nombreArchivo}");
    }
 
    public void Escribir(string contenido)
    {
        Console.WriteLine($"[LibreriaExportPDFv2] Escribiendo contenido...");
    }
 
    public string Cerrar()
    {
        Console.WriteLine($"[LibreriaExportPDFv2] Cerrando archivo y generando salida.");
        return "Documento generado: 245 bytes simulados";
    }
}
