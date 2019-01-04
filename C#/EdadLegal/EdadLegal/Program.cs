using System;

namespace EdadLegal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba su nombre y pulse enter:");
            string nombre = Console.ReadLine(); // creo variable nombre y la almaceno en Console.
            Console.WriteLine("Escriba su edad y pulse enter:");
            int edad = int.Parse(Console.ReadLine()); // paso string a int
            if (edad >= 18)
            {
                Console.WriteLine("Tu nombre es " + nombre + " y legalmente sos mayor de edad");
            }
            else
            {
                Console.WriteLine("Tu nombre es " + nombre + " y no sos mayor de edad");
            }
        }
    }
}
