public class ExcelAdapter : IGeneradorReporte
{
    private LibreriaExcelExterna _libreriaExcel = new LibreriaExcelExterna();

    public string GenerarReporte(string nombreArchivo,string contenido)
    {
        bool correcto = _libreriaExcel.CrearHojaCalculo(nombreArchivo, contenido);
        if (correcto )
        {
            return $" Reporte generado correctamente: {nombreArchivo}";
        }
        else
        {
            return $" Error al generar el reporte.........";
        } 
    }
}