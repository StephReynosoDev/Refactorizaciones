namespace Practica3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("**********************************");
                Console.WriteLine("\n[BIENVENIDO AL GESTOR DE SALARIO]");
                Console.WriteLine("**********************************");

                Console.WriteLine("\nSELECCIONE EL TIPO DE EMPLEADO:");
                Console.WriteLine("1. (EMPLEADO POR HORA)");
                Console.WriteLine("2. (EMPLEADO ASALARIADO)");
                Console.WriteLine("3. (EMPLEADO POR COMISION)");

                // Leemos la entrada y validamos que sea un número entero
                if (int.TryParse(Console.ReadLine(), out int opcion))
                {
                    // Implementación del Factory y Strategy
                    ICalculo estrategia = EmpleadoFactory.ImplementarCalculo(opcion);
                    EmpleadoContext context = new EmpleadoContext(estrategia).
                    
                
                else
                {
                    Console.WriteLine("\nError: Por favor, ingrese un numero válido del 1 al 3.");
                }
            }
            }
            catch (Exception ex)
            {
                // Ahora sí capturamos y mostramos cualquier error inesperado
                Console.WriteLine($"\nOcurri un error inesperado: {ex.Message}");
            }
        }
    }
}