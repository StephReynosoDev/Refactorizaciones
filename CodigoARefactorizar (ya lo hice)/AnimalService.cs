using System;

namespace AnimalesFactory
{
public class AnimalService
    {
        public void CrearAnimal(string medio)
        {
            if (medio == "Tierra")
            {
                Cuadrupedo animal = new Cuadrupedo();
                animal.MostrarTipo();
            }
            else if (medio == "Aire")
            {
                Ave animal = new Ave();
                animal.MostrarTipo();
            }
            else if (medio == "Agua")
            {
                Pez animal = new Pez();
                animal.MostrarTipo();
            }
            else
            {
                Console.WriteLine("Medio no válido.");
            }
        }
    }
}