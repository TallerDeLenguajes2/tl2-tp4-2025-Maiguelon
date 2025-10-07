using System.Collections;
using System.Numerics;
using System.Text.Json;


namespace miCadeteria
{
    public interface IAccesoADatosClientes
    {
        List<Cliente> CargarClientes(string archivo);
    }

    public class AccesoADatosClientesJSON : IAccesoADatosClientes
    {
        public List<Cliente> CargarClientes(string archivo)
        {
            string linea = File.ReadAllText(archivo);
            List<Cliente> clientes = JsonSerializer.Deserialize<List<Cliente>>(linea);
            return clientes;
        }
    }
}