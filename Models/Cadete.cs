using System.Linq;

namespace miCadeteria
{
    public class Cadete
    {
        // constante del jornal
        private const int PagoPorPedido = 5000;
        private int id;
        private string nombre;
        private string direccion;
        private string telefono;

        public Cadete()
        {
        }

        public Cadete(int id, string nombre, string direccion, string telefono)
        {
            this.id = id;
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
        }
        public Int32 Id { get => id; set => id = value; }
        public String Nombre { get => nombre; set => nombre = value; }
        public String Direccion { get => direccion; set => direccion = value; }
        public String Telefono { get => telefono; set => telefono = value; }
    }
}