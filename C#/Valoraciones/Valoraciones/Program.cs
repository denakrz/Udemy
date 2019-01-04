using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LibroValoraciones.nombre);
            LibroValoraciones libro = new LibroValoraciones(); // constructor para crear un objeto. Asigna un espacio de memoria para la variable.
            libro.AgregarValoracion(3.5f); // le agrego una f porque es un float.
            libro.AgregarValoracion(4);

            LibroValoraciones libro2 = new LibroValoraciones(); // creo un objeto nuevo, nuevo espacio de memoria. | si igualo libro2 = libro compartirían el mismo espacio de memoria y tendrían los mismos datos, propiedades, métodos, etc.
            libro2.AgregarValoracion(2);
        }
    }
}
