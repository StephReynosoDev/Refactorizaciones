class Program
{
    static void Main(string[] args)
    {

        IGeneradorReporte adaptadorPDF = new PDFAdapter();
        Cliente cliente = new Cliente(adaptadorPDF);
        cliente.ExportarReporte("archivo pdf generado... ", "reporte.pdf");


     
        IGeneradorReporte adaptadorExcel = new ExcelAdapter();
        Cliente cliente2 = new Cliente(adaptadorExcel);
        cliente2.ExportarReporte("contenido de la hoja de cálculo generado... ", "reporte.xlsx");

        
        IGeneradorReporte adaptadorExportPDF = new ExportAdapter();
        Cliente cliente3 = new Cliente(adaptadorExportPDF);
        cliente3.ExportarReporte("archivo de exportación pdf generado... ", "reporte.pdf");
    }
}