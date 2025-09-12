namespace miCadeteria
{
    public class Cliente
    {
        private string nombre;
        private string direccion;
        private string telefono;
        private string datosReferenciaDireccion;
        private int id;

        public String Nombre { get => nombre; set => nombre = value; }
        public String Direccion { get => direccion; set => direccion = value; }
        public String Telefono { get => telefono; set => telefono = value; }
        public String DatosReferenciaDireccion { get => datosReferenciaDireccion; set => datosReferenciaDireccion = value; }
        public int Id { get => id; set => id = value; }

        public Cliente()
        {
        }
        public Cliente(string nombre, string direccion, string phone, string datosReferenciaDirecion, int id)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = phone;
            this.datosReferenciaDireccion = datosReferenciaDirecion;
            this.id = id;
        }
    }
 }