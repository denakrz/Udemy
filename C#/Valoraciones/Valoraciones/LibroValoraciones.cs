using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones
{
    class LibroValoraciones
    {
        public static string nombre = "Cuca"; // static = nunca cambia
        List<float> valoraciones;

        public LibroValoraciones()
        {
            valoraciones = new List<float>();
        }
        public void AgregarValoracion(float valoracion) // debe ser public para poder acceder desde program
        {
            // valoracion = valoracion + 5; al numero que entre le sumo 5
            valoraciones.Add(valoracion);
        }

    }
}
