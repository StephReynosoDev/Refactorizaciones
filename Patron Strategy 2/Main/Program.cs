namespace Strategy2
{
    class Program
    {
        static void Main(string[] args)
{
       Console.WriteLine("\n======[Bienvenido Al Sistema De Manejo de Salarios]======");
       Console.WriteLine("\nDigite su Nombre Completo: ");
       string nombre = Console.ReadLine()!;

       Console.WriteLine("\n[Digite Su Salario]: ");
       double salario = double.Parse(Console.ReadLine()!);





       Console.WriteLine("\n[Digite su Tipo de Empleabilidad]: ");
       Console.WriteLine("\n[1] Empleado Tiempo Completo.");
       Console.WriteLine("\n[2] Empleado Tiempo Medio.");
       Console.WriteLine("\n[3] Empleado Por Contrato.");
       int opcionEmpleado = int.Parse(Console.ReadLine()!);

       IImpuestos estrategia;
       EmpleadoContext empleado = null;


    try{

       switch (opcionEmpleado)
                {
                    case 1:
                        estrategia = new ImpuestoCompleto();
                        empleado = new EmpleadoContext(estrategia, nombre, salario, TipoEmpleado.EmpleadoTiempoCompleto);
                        empleado.EjecutarImpuestos();
                    break;

                    case 2:
                        estrategia = new ImpuestoMedio();
                        empleado = new EmpleadoContext(estrategia, nombre, salario, TipoEmpleado.EmpleadoMedioTiempo);
                        empleado.EjecutarImpuestos();
                    break;

                    case 3:
                        estrategia = new ImpuestoContrato();
                        empleado = new EmpleadoContext(estrategia, nombre, salario, TipoEmpleado.EmpleadoPorContrato);
                        empleado.EjecutarImpuestos();
                    break;
                }
       
        Console.WriteLine("====[Elija El Formato Deseado]====");
        Console.WriteLine("\n[1] Formato TXT.");
        Console.WriteLine("\n[2] Formato XLSX.");
        Console.WriteLine("\n[3] Formato JSON.");
        int opcionEXP = int.Parse(Console.ReadLine()!);

        IExportacion exportaciones;
    


        try{

                switch (opcionEXP)
                    {
                        case 1:
                        exportaciones = new TXTExport();
                        exportaciones.ExportarInfo(empleado);
                        break;

                        case 2:
                        exportaciones = new ExcelExport();
                        exportaciones.ExportarInfo(empleado);
                        break;

                        case 3:
                        exportaciones = new JSONExport();
                        exportaciones.ExportarInfo(empleado);
                        break;
                    }





                }
                catch(Exception ex)
                {
                    throw new ArgumentException("La opcione que ingresaste fue invalida. Ingrese otra opcion.: {ex.Message}");

                        
                   
                } 
}               catch(Exception ex)
            {
                throw new ArgumentException($"La opcione que ingresaste fue invalida. Ingrese otra opcion: {ex.Message}");
                
            }
}
}
}

