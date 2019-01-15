using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Speech;
using System.Speech.Synthesis;
using Valoraciones2.EstructurasDeControl;

namespace Valoraciones2
{
    class Program
    {
        static void Main(string[] args)
        {
            // crear objeto libro
            LibroValoraciones libro = new LibroValoraciones();
            libro.Idioma = IdiomaLibro.ES; // Asigno idioma con enum, clase IdiomaLibro
            libro.Nombre = "Valoraciones";
            libro.Nombre = ""; // no lo muestra porque es null
          //  Console.WriteLine(libro.Nombre);

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

            float valoracionMinima = publicar.ValoracionMin;
            float valoracionMaxima = publicar.ValoracionMax;
            float promedioValoraciones = publicar.PromedioValoraciones;

            // Console.WriteLine("Este es el resultado de las valoraciones");
            // EscribirValoraciones("El promedio es: " , (int)promedioValoraciones); // 3,65 // 3
            // EscribirValoraciones("El valor mínimo es: " , (int)valoracionMinima); // 1.2 // 1
            // EscribirValoraciones("El valor máximo es: " , (int)valoracionMaxima); // 5 // 5

            // SwitchCase misCasos = new SwitchCase();
            // misCasos.EjemploSwitchCase1();
            //  misCasos.EjemploSwitchCase2();
            // misCasos.EjemploSwitchCase3();

            Bucles miBucle = new Bucles();
           // miBucle.BuclesForEach();
           // miBucle.BuclesForLoop();
           // miBucle.BuclesWhile();
            miBucle.BuclesDoWhile();
            
           // Condicionales condicionales = new Condicionales();
           // condicionales.ComprobacionesConRetorno();

          //  AsignarLetraVal("La letra de tu valoración es: " + libro.ValoracionesLetras); // B

            Console.ReadLine();
 
        }

        private static void AsignarLetraVal(string descripcion)
        {
            Console.WriteLine(descripcion);
        }

        private static void EscribirValoraciones(string descripcion, int valoracion) //transformo el decimal a un entero 
        {
            Console.WriteLine("{0}" + "{1}", descripcion, valoracion);
        }
    }
}
