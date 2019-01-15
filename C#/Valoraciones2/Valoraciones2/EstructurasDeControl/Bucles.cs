using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones2.EstructurasDeControl
{
    class Bucles
    {
        //Funcionalidad: recorrer colecciones de datos (Array, arraylist, listas, diccionarios)

        public void BuclesForEach()
        {
            int[] array1 = { 0, 1, 2, 3, 4, 5 };

            // numéricos
            foreach (int n in array1)
            {
                Console.WriteLine("For each string + ", n.ToString()); // transformo a string
            }


            //string

            string[] array2 = { "Hola", "que", "tall" };

            foreach (string s in array2) // recorre todos los datos de la lista
            {
                Console.WriteLine("For each string: " + s);
            }
        }

        public void BuclesForLoop()
        {
            // array de enteros
            int[] array1 = { 0, 1, 2, 3, 4, 5 };

            for (int i = 0; i <= 5; i++) // para no salirse del rango! index out of range
            {
                Console.WriteLine("For loop int " + array1[i].ToString());
            }

            //  array de strings
            string[] array2 = { "Hola", "Tengo", "Hambre" };

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("For loop string " + array2[i]);
            }
        }

        public void BuclesWhile()
        {
            int[] array1 = { 0, 1, 2, 3, 4, 5 };
            int x = 0;

            while (x < 6)
            {
                Console.WriteLine("While int " + array1[x].ToString());
                x++;
            }

            string[] array2 = { "Hola", "toi llena" };
            int y = 0;

            while (y < 2)
            {
                Console.WriteLine("While string " + array2[y]);
                y++;
            }
        }

        public void BuclesDoWhile()
        {
            int[] array1 = { 0, 1, 2, 3, 4, 5 };
            int x = 0;

            do
            {
                Console.WriteLine("Do while int " + array1[x].ToString());
                x++;
            } while (x < 6);

            string[] array2 = { "Hola", "Mundo" };
            int y = 0;

            do
            {
                Console.WriteLine("Do while string " + array2[y]);
                y++;
            } while (y < 2);
        }
    }
}
