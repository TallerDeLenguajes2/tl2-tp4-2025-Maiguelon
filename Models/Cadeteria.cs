using System.Collections;
using System.Numerics;

namespace miCadeteria
{
    public class Cadeteria
    {
        private string nombre;
        private string numero;
        private List<Cadete> cadetes;
        private List<Cliente> clientes;
        private List<Pedidos> ListadoPedidos;

        public Cadeteria()
        {
        }

        public Cadeteria(string name, string number)
        {
            nombre = name;
            numero = number;
            cadetes = new List<Cadete>();
            clientes = new List<Cliente>();
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Numero { get => numero; set => numero = value; }
        public List<Cadete> Cadetes { get => cadetes; set => cadetes = value; }
        public List<Cliente> Clientes { get => clientes; set => clientes = value; }
        public List<Pedidos> ListadoPedidos1 { get => ListadoPedidos; set => ListadoPedidos = value; }

        public void DarDeAltaPedido(int numero, string obs, string plato, int idCliente)
        {
            Cliente client = Clientes.FirstOrDefault(c => c.Id == idCliente);

            if (client != null)
            {
                Pedidos pedido = new Pedidos(numero, obs, estado_pedido.Preparandose, plato, client);
                ListadoPedidos.Add(pedido);
            }
        }


        public void ReasignarPedido(Cadete cadete, Pedidos pedido)
        {
            pedido.Cadete = cadete;
        }

        // Carga del csv
        public static Cadeteria CargarCadeteriaCSV(string archivo)
        {
            string linea = File.ReadAllLines(archivo).First();
            var partes = linea.Split(',');
            Cadeteria cadeteria = new Cadeteria(partes[0], partes[1]);
            return cadeteria;
        }

        public static List<Cadete> CargarCadetesCSV(string archivo)
        {
            List<Cadete> lista = new List<Cadete>();
            foreach (var linea in File.ReadAllLines(archivo))
            {
                var partes = linea.Split(',');
                Cadete cadete = new Cadete(Convert.ToInt32(partes[0]), partes[1], partes[2], partes[3]);
                lista.Add(cadete);
            }
            return lista;
        }

        public static List<Cliente> CargarClientesCSV(string archivo)
        {
            List<Cliente> lista = new List<Cliente>();
            foreach (var linea in File.ReadAllLines(archivo))
            {
                var partes = linea.Split(',');
                Cliente cliente = new Cliente(partes[0], partes[1], partes[2], partes[3], Convert.ToInt32(partes[4]));
                lista.Add(cliente);
            }
            return lista;
        }

        // Cosas de informe
        public double PromedioPedidos()
        {
            return (double)ListadoPedidos
            .Where(p => p.Cadete != null).Count() / cadetes.Count();
        }

        public int JornalACobrar(int id)
        {
            int PagoPorPedido = 5000;
            return ListadoPedidos
            .Where(p => p.Cadete.Id == id
            && p.Estado == estado_pedido.Listo).Count() * PagoPorPedido;
        }

        public Pedidos DevolverPedido(int nroPedido)
        {
            return ListadoPedidos.Find(c => c.Nro == nroPedido);
        }

        public Cadete DevolverCadete(int idCadete)
        {
            return cadetes.Find(c => c.Id == idCadete);
        }

        public void AsignarCadeteAPedido(int idCadete, int idPedido)
        {
            Pedidos pedidoAsignable = DevolverPedido(idPedido);
            Cadete cadeteAsignado = DevolverCadete(idCadete);

            if (pedidoAsignable != null && cadeteAsignado != null)
            {
                pedidoAsignable.Cadete = cadeteAsignado;
            }
        }

        public Cadete EncontrarCadete(int nroPedido)
        {
            Pedidos pedido = DevolverPedido(nroPedido);
            return pedido.Cadete;
        }
    }
}