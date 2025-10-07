namespace miCadeteria
{
    public enum estado_pedido
    {
        Preparandose = 1,
        Listo_para_retirar = 2,
        En_camino = 3,
        Listo = 4
    }
    public class Pedidos
    {
        private int nro;
        private string observacion;
        private string plato;
        private Cliente cliente;
        private estado_pedido estado;
        private Cadete cadete;

        public Pedidos()
        {
        }
        public Pedidos(int number, string obs, estado_pedido state, string platillo, Cliente cliente)
        {
            nro = number;
            observacion = obs;
            this.cliente = cliente;
            estado = state;
            plato = platillo;
            this.cadete = new Cadete();
        }

        public Int32 Nro { get => nro; set => nro = value; }
        public String Obervacion { get => observacion; set => observacion = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public estado_pedido Estado { get => estado; set => estado = value; }
        public string Plato { get => plato; set => plato = value; }
        public Cadete Cadete { get => cadete; set => cadete = value; }

        public string VerDireccionCliente()
        {
            return cliente.Direccion;
        }

        public string VerDatosCliente()
        {
            return $"Nombre: {cliente.Nombre}, Direccion: {cliente.Direccion}, Telefono: {cliente.Telefono}, Detalles: {cliente.DatosReferenciaDireccion}";
        }

        public void CambioEstado(estado_pedido state)
        {
            estado = state;
        }
    }
}