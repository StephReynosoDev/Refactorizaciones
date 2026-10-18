namespace Grupo1_Inventario
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("\n=== Sistema de Consulta de Inventario ===");
                Console.WriteLine("1. Inventario Local");
                Console.WriteLine("2. Bodega Central (XML)");
                Console.WriteLine("3. Proveedor Externo");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine() ?? "";

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese el código de producto: ");
                        string codigo1 = Console.ReadLine() ?? "";
                        InventarioLocal inventarioLocal = new InventarioLocal();
                        IGestorInventario adaptador1 = new InventarioLocalAdapter(inventarioLocal);
                        Cliente cliente = new Cliente(adaptador1);
                        cliente.ConsultarProducto(codigo1);
                        break;

                    case "2":
                        Console.WriteLine("Funcionalidad ya disponible arreglamo eta vaina.");
                        Console.Write("Ingrese el código de producto: ");
                        string codigo2 = Console.ReadLine() ?? "";
                        BodegaCentralXML bodegaCentralXML = new BodegaCentralXML();
                        IGestorInventario adaptador2 = new BodegaXMLAdapter(bodegaCentralXML);
                        Cliente cliente2 = new Cliente(adaptador2);
                        cliente2.ConsultarProducto(codigo2);
                        break;

                    
                    case "3":
                        Console.WriteLine("Funcionalidad ya disponible arreglamo eta vaina.");
                        Console.Write("Ingrese el código de producto: ");
                        string codigo3 = Console.ReadLine() ?? "";
                        ProveedorExternoStock proveedorExterno = new ProveedorExternoStock();
                        IGestorInventario adaptador3 = new ProveedorExternoAdapter(proveedorExterno);
                        Cliente cliente3 = new Cliente(adaptador3);
                        cliente3.ConsultarProducto(codigo3);
                        break;

                    case "0":
                        Console.WriteLine("Gracias por usar el sistema, cerrando......");
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
    }
}
