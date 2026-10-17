namespace Practica2;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("");
            Console.WriteLine("   ***SISTEMA DE VENTAS - TIENDA***");
            Console.WriteLine("");
            Console.WriteLine("Seleccione el tipo de producto:");
            Console.WriteLine("1. Electronico");
            Console.WriteLine("2. Ropa");
            Console.Write("Opcion: ");

            if (!int.TryParse(Console.ReadLine(), out int opcionMenu) || opcionMenu < 1 || opcionMenu > 2)
            {
                Console.WriteLine("Error..: Opcion invalida.");
                return;
            }

            TipoProducto tipoSeleccionado = (TipoProducto)(opcionMenu - 1);

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine()!;

            Console.Write("Precio: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal precio) || precio <= 0)
            {
                Console.WriteLine("Error..: Precio invalido.");
                return;
            }

            Productos productoRegistrado = ProductoFactory.CrearProducto(tipoSeleccionado, nombre, precio);

            productoRegistrado.MostrarDetalles();
            GestorDatos.GuardarHistorialEnDisco(productoRegistrado);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error...: {ex.Message}");
        }
    }
}