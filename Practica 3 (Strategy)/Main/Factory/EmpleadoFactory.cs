namespace Practica3
{
    public class EmpleadoFactory
    {
        public static ICalculo ImplementarCalculo(int opcion)
        {
            switch (opcion)
            {
                case 1:
                return new EmpleadoHora();

                case 2:
                return new EmpleadoAsalariado();

                case 3: 
                return new EmpleadoComision();
                
                default:
                  throw new ArgumentException("error.......");
            }
        }
    }
}
    