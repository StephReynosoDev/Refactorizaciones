
using System.Linq.Expressions;

namespace Strategy
{
    
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[Elija una Raza para Pasear]");
          Console.WriteLine("[1] CHIGUAGUA");
            Console.WriteLine("[2] LABRADOR");
            Console.WriteLine("[3] HUSKY SIBERIANO");
            Console.WriteLine("[4] SALIR");

            int opcion = int.Parse(Console.ReadLine()!);

        try{
            switch (opcion)
            {
                case 1:
                IPaseo strategy = new ChiguaguaStrategy();
                Paseador paseador = new Paseador(strategy);
                paseador.EjecutarPaseo();
                break;


                case 2:
                IPaseo strategy2 = new LabradorStrategy();
                Paseador paseador2 = new Paseador(strategy2);
                paseador2.EjecutarPaseo();
                break;


                case 3:
                IPaseo strategy3 = new HuskyStrategy();
                Paseador paseador3 = new Paseador(strategy3);
                paseador3.EjecutarPaseo();
                break;
                default:
                        throw new ArgumentException("Opcion Invalida........");


                case 4:
                Console.WriteLine("Saliendo del sistema........");     
                return; 
               
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error..... {ex.Message}");
        

    }
}
}
}
