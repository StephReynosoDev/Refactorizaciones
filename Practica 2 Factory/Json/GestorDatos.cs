
using System.Text.Json;
namespace Practica2{
public static class GestorDatos
    {

        private const string NombreArchivoJson = "venta.json";

        public static void GuardarHistorialEnDisco(Productos productoCreado)
        {
            try
            {
                var opcionesFormato = new JsonSerializerOptions { WriteIndented = true };
                
                
                string stringTextoJson = JsonSerializer.Serialize<object>(productoCreado, opcionesFormato);
                
                File.WriteAllText(NombreArchivoJson, stringTextoJson);
                
                Console.WriteLine("Guardado en venta.json");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError..: No se pudo escribir el archivo: {ex.Message}");
            }
        }
    }
}
