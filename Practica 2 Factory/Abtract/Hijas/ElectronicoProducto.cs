namespace Practica2
{
    public class ElectronicoProducto : Productos
    {
        public int MesesGarantia { get; set; }
        public string Accesorios { get; set; }

        public override void MostrarDetalles()
        {
            Console.WriteLine($"\nProducto registrado: {Nombre} (${Precio})");
            Console.WriteLine($"Garantia: {MesesGarantia} meses");
            Console.WriteLine($"Accesorios: {string.Join(", ", Accesorios)}");
        }
        

    }
}