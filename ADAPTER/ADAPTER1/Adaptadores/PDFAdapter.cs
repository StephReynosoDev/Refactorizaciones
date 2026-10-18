public class PDFAdapter : IGeneradorReporte 
{
    private GeneradorReportePDF _generadorPDF = new GeneradorReportePDF();

    

    public string GenerarReporte(string contenido, string nombreArchivo)
{
    return _generadorPDF.GenerarPDF(contenido, nombreArchivo);
}
}

