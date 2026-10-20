using ClosedXML.Excel;

namespace Strategy2

{
    public class ExcelExport : IExportacion
    {
        public void ExportarInfo(EmpleadoContext exportacion)
        {
            var libro = new XLWorkbook();
            var hoja = libro.Worksheets.Add("Datos");

            hoja.Cell(1, 1).Value = "Nombre";
            hoja.Cell(1, 2).Value = "Salario";
            hoja.Cell(1, 3).Value = "Impuestos";
            hoja.Cell(1, 4).Value = "Tipo de Empleados";


            hoja.Cell(2, 1).Value = exportacion.Nombre;
            hoja.Cell(2, 2).Value = exportacion.Salario;
            hoja.Cell(2, 3).Value = exportacion.Impuesto;
            hoja.Cell(2, 4).Value = exportacion.TipoEmpleados.ToString();

            libro.SaveAs("exportacion.xlsx");
            Console.WriteLine("Exportando en xlsx a exportacion.xlsx.......");
        }
    }
}