namespace Practica3
{
    public class EmpleadoHora : ICalculo
    {

        public void CalcularComision(EmpleadoContext empleado){

            double horas = double.Parse(Console.ReadLine() ?? "0");
            
           
            double tarifa = double.Parse(Console.ReadLine() ?? "0");
            
            Console.WriteLine($"\nSalario calculado: {horas * tarifa}");
    }
}
}
    