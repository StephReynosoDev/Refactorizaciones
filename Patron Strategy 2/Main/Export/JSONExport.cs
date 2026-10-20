using System.Text.Json;

namespace Strategy2
{
     public class JSONExport : IExportacion
    {
        public void ExportarInfo(EmpleadoContext exportacion)
        {
            var exportJSON = new JsonSerializerOptions {WriteIndented = true};
            string json = JsonSerializer.Serialize(exportacion, exportacion.GetType(), exportJSON );
            File.WriteAllText("exportacion.json", json);
            Console.WriteLine("Exportando en json a exportacion.json.......");
        }
    }
}