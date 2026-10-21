class Program
{
    static void Main(string[] args)
    {
        
        Configuracion confi1 = Configuracion.ObtenerInstancia();

        
          Console.Write(" [BIENVENIDO A LA CONFIGURACION DE APP] ");
          Console.Write("\nIngrese el nombre de la app: ");
          confi1.NombreApp = Console.ReadLine();



          Console.Write("\nIngrese la version de la app: ");
          confi1.Version = Console.ReadLine();

          Console.Write(" ====[MENU]==== ");
          Console.Write("\n1. Ver Configuracion ");
          Console.Write("\n2. Cambiar el nombre ");
          Console.Write("\nOPCION: ");
          int opcion = int.Parse(Console.ReadLine()!);

          switch (opcion)
        {
            case 1:
            confi1.MostrarInfo();
            break;

            case 2:
            Console.Write("\nCambiar Nombre de la App: ");
            confi1.NombreApp = Console.ReadLine();
            confi1.MostrarInfo();
            break;

           //ReferenceEquals compara si dos variables apuntan exactamente al mismo espacio en memoria, no si tienen los mismos valores.
        }
            

    }
}
