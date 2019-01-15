using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Valoraciones2
{
    public class LibroValoraciones // internal: accesible para todas las clses dentro de este proyecto
    {
        private string _valoracionesLetras;
        public string ValoracionesLetras
        {
            get
            {
                return _valoracionesLetras;
            }
        }

        private string _nombre;
        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                if (!String.IsNullOrEmpty(value)) // si el string no es null o vacío
                {
                    _nombre = value; // asignalo a nombre
                }
            }
        }

        public IdiomaLibro Idioma;
        private List<float> valoraciones;

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
            AsignarLetraVal(calculo.PromedioValoraciones);
            return calculo;
        }

        private void AsignarLetraVal(float promedioValoraciones)
        {
            if (promedioValoraciones <= 5 && promedioValoraciones > 4)
            {
                _valoracionesLetras = "A";      
            }
            else if (promedioValoraciones <= 4 && promedioValoraciones > 3)
            {
                _valoracionesLetras = "B";
            }
            else if (promedioValoraciones <= 3 && promedioValoraciones > 2)
            {
                _valoracionesLetras = "C";
            }
            else if (promedioValoraciones <= 2 && promedioValoraciones > 1)
            {
                _valoracionesLetras = "D";
            }
            else
            {
                _valoracionesLetras = "E";
            }
            
        }

        public void AgregarValoracion(float valoracion) // debe ser public para poder acceder desde program
        {
            // valoracion = valoracion + 5; al numero que entre le sumo 5
            valoraciones.Add(valoracion);
        }
    }
}
