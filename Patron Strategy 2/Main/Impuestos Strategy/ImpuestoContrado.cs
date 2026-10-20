namespace Strategy2
{

    public class ImpuestoContrato : IImpuestos
    {
        public double CalcularImpuestos(double Salario)
        {
            return Salario * 0.15;
        }
    }
}