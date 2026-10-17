namespace Practica3
{
    public class EmpleadoAsalariado : ICalculo
    {
        public void CalcularComision(EmpleadoContext empleado)
        {
         
            double sueldo = double.Parse(Console.ReadLine() ?? "0");
            
            Console.WriteLine($"\nSalario calculado: {sueldo}");
        }
    }
        }
    

    