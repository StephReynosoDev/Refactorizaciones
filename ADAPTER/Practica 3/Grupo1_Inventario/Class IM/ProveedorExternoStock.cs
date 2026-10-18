namespace Grupo1_Inventario
{
    class ProveedorExternoStock
    {
        private bool _conectado = false;

        public void Conectar()
        {
            _conectado = true;
            Console.WriteLine("[ProveedorExternoStock] Conexión establecida.");
        }

        public int ObtenerCantidad(string codigo)
        {
            if (!_conectado)
                throw new InvalidOperationException("Debe conectar antes de consultar.");
            Console.WriteLine($"[ProveedorExternoStock] Cantidad obtenida para {codigo}");
            return 15;
        }

        public void Desconectar()
        {
            _conectado = false;
            Console.WriteLine("[ProveedorExternoStock] Conexión cerrada.");
        }
    }
}
