using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech;
using System.Speech.Synthesis;

namespace Valoraciones2
{
    class Program
    {
        static void Main(string[] args)
        {
            // crear objeto libro
            LibroValoraciones libro = new LibroValoraciones();
            SpeechSynthesizer hablar = new SpeechSynthesizer();

            // asigno valoraciones
            libro.AgregarValoracion(1.2f); // le agrego una f porque es un float.
            libro.AgregarValoracion(5);
            libro.AgregarValoracion(5);
            libro.AgregarValoracion(3.4f);


            // publicar valoraciones
            hablar.Speak("Este es el resultado de las valoraciones");
            CalcularValoraciones publicar = libro.PublicarValoraciones();
            Console.WriteLine("El promedio es: " + publicar.promedioValoraciones); // 3,65
            Console.WriteLine("El valor mínimo es: " + publicar.valoracionMin); // 1.2
            Console.WriteLine("El valor máximo es: " + publicar.valoracionMax); // 5
            Console.ReadLine(); 

            // valoracion mínima

            // valoración máxima

            // promedio valoraciones
        }
    }
}
