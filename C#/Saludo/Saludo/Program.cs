using System;

namespace Saludo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola " + args[0] + " " + args[1]); // encadeno - args + número de posición
        }
    }
}

/////TEORÍA/////

/* Tipos de errores
 * Error de sintaxis -> escribimos mal o llamamos a un elemento que no existe.
 * Runtime -> cuando se ejecuta el problema, si recibe un dato que no espera.
 */

/* Errores que puede tener esto
 * Runtime -> al pasarle un arg en posición 0, si ejecuto sin mandarle un argumento va a dar error.
 * Para pasarle datos vamos a Saludo\Propiedades\Debug y agrego un argumento.
 */

/* Breakpoints
 * Usarlos para debuggear
 * F11 va recorriendo el programa línea por línea
 * F10 va hasta el próximo breakpoint
 * F5 continuar
 */
