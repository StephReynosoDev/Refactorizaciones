
class Program
{
    static void Main()
    {
        Console.WriteLine("=== Sistema de Relojes ===");
        Console.WriteLine("Este sistema solo consumia el reloj digital.");

         Console.WriteLine("Ahora tiene 2 opciones: [1] Reloj Digital, [2] Reloj Analogico");

        string opcion = Console.ReadLine();

         if (opcion == "1")
        {
            Console.Write("Presione Enter para mostrar la hora digital...");
             Console.ReadLine();
            
             RelojDigital relojDigital = new RelojDigital();
             IReloj adaptadorDigital = new RelojDigitalAdapter(relojDigital);
             Pantalla pantalla = new Pantalla();
             pantalla.MostrarHora(adaptadorDigital);


        }else if (opcion == "2")
        {

            Console.Write("Ingrese la hora (0-23): ");
            int hora = int.Parse(Console.ReadLine());

            Console.Write("Ingrese los minutos (0-59): ");
            int minutos = int.Parse(Console.ReadLine());

            Console.Write("Ingrese los segundos (0-59): ");
            int segundos = int.Parse(Console.ReadLine());

            RelojAnalogico relojAnalogico = new RelojAnalogico(hora, minutos, segundos);
            IReloj adaptadorAnalogico = new RelojAnalogicoAdapter(relojAnalogico);
            Pantalla pantalla2 = new Pantalla();
            pantalla2.MostrarHora(adaptadorAnalogico);
          

        }else
        {
            Console.WriteLine("Opción inválida. Por favor, seleccione 1 o 2.");
        }

        
       
    }
}