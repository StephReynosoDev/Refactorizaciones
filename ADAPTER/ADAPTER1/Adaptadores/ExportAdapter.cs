public class ExportAdapter : IGeneradorReporte
{
    private LibreriaExportPDFv2 _libreriaExportPDF = new LibreriaExportPDFv2();

    public string GenerarReporte(string nombreArchivo, string contenido)
    {
        _libreriaExportPDF.Abrir(nombreArchivo);
        _libreriaExportPDF.Escribir(contenido);
        string resultadoFinal = _libreriaExportPDF.Cerrar();

        return $"Exportado correctamente: {resultadoFinal}";
    }
}
