namespace Strategy2
{
     public class TXTExport : IExportacion
    {
        public void ExportarInfo(EmpleadoContext exportacion)
        {
            string contenidoClase = $"Nombre: {exportacion.Nombre}\nSalario: {exportacion.Salario}\nImpuesto: {exportacion.Impuesto}\nTipo De Empleado: {exportacion.TipoEmpleados}";
            File.WriteAllText("Empleado.txt", contenidoClase);
            Console.WriteLine("Exportando en txt a exportacion.txt......");
        }

    }
}