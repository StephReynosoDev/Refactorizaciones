namespace Practica2
{
    public static class ProductoFactory
    {
        public static Productos CrearProducto(TipoProducto tipo, string nombre, decimal precio)
        {
            switch (tipo)
            {
                case TipoProducto.Electronico:
                    Console.Write("Garantia (meses): ");
                    int meses = int.Parse(Console.ReadLine()!);

                    Console.Write("Accesorios: ");
                    string accesorios = Console.ReadLine()!;

                    return new ElectronicoProducto
                    {
                        Nombre = nombre, Precio = precio, Tipo = tipo,
                        MesesGarantia = meses, Accesorios = accesorios
                    };

                case TipoProducto.Ropa:
                    Console.WriteLine($"Tallas Disponibles: S/M/X/XL");
                    Console.Write("Tallas: ");
                    string tallas = Console.ReadLine()!;

                    return new RopaProducto
                    {
                        Nombre = nombre, Precio = precio, Tipo = tipo, Tallas = tallas
                    };

                default:
                    throw new ArgumentException("Tipo incorrecto.");
            }
        }
    }
}