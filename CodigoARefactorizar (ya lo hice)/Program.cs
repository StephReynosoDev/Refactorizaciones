using System;

namespace AnimalesFactory
{
    public class Program
    {
        public static void Main()
        {
            AnimalService servicio = new AnimalService();

            servicio.CrearAnimal("Tierra");
            servicio.CrearAnimal("Aire");
            servicio.CrearAnimal("Agua");
        }
    }
}