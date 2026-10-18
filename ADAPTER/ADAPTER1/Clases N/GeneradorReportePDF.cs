public class GeneradorReportePDF
{
    public string GenerarPDF(string contenido, string nombreArchivo)
    {
        Console.WriteLine($"[GeneradorReportePDF] Generando PDF: {nombreArchivo}");
        return $"PDF generado: {nombreArchivo}";
    }
}
