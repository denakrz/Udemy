using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Speech;
using System.Speech.Synthesis;

namespace Valoraciones2
{
    class Program
    {
        static void Main(string[] args)
        {
            // crear objeto libro
            LibroValoraciones libro = new LibroValoraciones();
            libro.Idioma = IdiomaLibro.ES; // Asigno idioma con enum, clase IdiomaLibro

            // SpeechSynthesizer hablar = new SpeechSynthesizer();
            
            /////// EJEMPLO QUE NO TIENE QUE VER CON LA APLICACIÓN ////////
            // Clase vector3d = Se usa cuando tenemos que usar variables que no están establecidas, las creamos por struct (estructura).
            Vector3D miVector;
            miVector.x = 10;
            miVector.y = 20;
            miVector.z = 15; 


            // asigno valoraciones
            libro.AgregarValoracion(1.2f); // le agrego una f porque es un float.
            libro.AgregarValoracion(5);
            libro.AgregarValoracion(5);
            libro.AgregarValoracion(3.4f);


            // publicar valoraciones
           // hablar.Speak("Este es el resultado de las valoraciones");
            CalcularValoraciones publicar = libro.PublicarValoraciones();
            Console.WriteLine("Este es el resultado de las valoraciones");
            Console.WriteLine("El promedio es: " + publicar.PromedioValoraciones); // 3,65
            Console.WriteLine("El valor mínimo es: " + publicar.ValoracionMin); // 1.2
            Console.WriteLine("El valor máximo es: " + publicar.ValoracionMax); // 5
           
            Console.ReadLine(); 
        }
    }
}
