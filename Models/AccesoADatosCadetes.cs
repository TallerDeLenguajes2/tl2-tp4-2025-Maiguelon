using System.Collections;
using System.Numerics;
using System.Text.Json;

namespace miCadeteria
{
    public interface IAccesoADatosCadetes
    {
        List<Cadete> CargarCadetes(string archivo);
    }

    public class AccesoADatosCadetesJSON : IAccesoADatosCadetes
    {
        public List<Cadete> CargarCadetes(string archivo)
        {
            string linea = File.ReadAllText(archivo);
            List<Cadete> cadetes = JsonSerializer.Deserialize<List<Cadete>>(linea);
            return cadetes;            
        }
    }
}