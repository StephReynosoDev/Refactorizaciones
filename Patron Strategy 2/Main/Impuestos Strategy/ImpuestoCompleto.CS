namespace Strategy2
{

    public class ImpuestoCompleto : IImpuestos
    {
        public double CalcularImpuestos(double Salario)
        {
            return Salario * 0.25;
        }
    }
}