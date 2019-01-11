using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Valoraciones2
{
    public class LibroValoraciones // internal: accesible para todas las clses dentro de este proyecto
    {
        public string Nombre; // para testear que cada vez que cree un libro le pongo un nombre
        public IdiomaLibro Idioma;
        List<float> valoraciones;

        public LibroValoraciones()
        {
            valoraciones = new List<float>();
        }

        public CalcularValoraciones PublicarValoraciones()
        {
            CalcularValoraciones calculo = new CalcularValoraciones();
            float sumaValoraciones = 0; // lo establezco en cero
            foreach (float valoracion in valoraciones) // recorro la lista de valoraciones
            {
                calculo.ValoracionMin = Math.Min(valoracion, calculo.ValoracionMin); // recorro lista y me quedo con la valoracion minima
                calculo.ValoracionMax = Math.Max(valoracion, calculo.ValoracionMax);
                sumaValoraciones += valoracion; // suma de valoraciones(0) + cantidad de valoraciones en lista = sumaValoraciones
            }

            calculo.PromedioValoraciones = sumaValoraciones / valoraciones.Count; // suma dividido cantidad de valoraciones
            return calculo;
        }
        public void AgregarValoracion(float valoracion) // debe ser public para poder acceder desde program
        {
            // valoracion = valoracion + 5; al numero que entre le sumo 5
            valoraciones.Add(valoracion);
        }
    }
}
