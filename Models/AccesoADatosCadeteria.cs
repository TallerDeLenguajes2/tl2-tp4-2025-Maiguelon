using System.Collections;
using System.Numerics;
using System.Text.Json;

namespace miCadeteria
{
    public interface IAccesoADatosCadeteria
    {
        Cadeteria CargarCadeteria(string archivo);
    }

    public class AccesoADatosCadeteriaJSON : IAccesoADatosCadeteria
    {
        public Cadeteria CargarCadeteria(string archivo)
        {
            string linea = File.ReadAllText(archivo);
            Cadeteria cadeteria = JsonSerializer.Deserialize<Cadeteria>(linea);
            return cadeteria;
        }
    }
}