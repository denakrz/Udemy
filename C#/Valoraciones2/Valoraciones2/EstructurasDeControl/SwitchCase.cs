using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones2.EstructurasDeControl
{
    class SwitchCase
    { 
        public void EjemploSwitchCase1()
        {
            int caseSwitch = 1;

            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Caso 1");
                    break;
                case 2:
                    Console.WriteLine("Caso 2");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }

        }

        public void EjemploSwitchCase2()
        {
            int switchExpression = 3;

            switch(switchExpression)
            {
                // Pueden tener mas de un caso
                case 0:

                case 1:
                    Console.WriteLine("Case 0 o 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                    // esta linea genera un warning ya que va después del salto, no lo lee.
                    // Console.WriteLine("Warning: Unreachable Code");

                // se pueden saltar numeros de casos
                case 7 - 4:
                    Console.WriteLine("Case 3");
                    break;

                // si el valor de switchExpression no es ni 0, 1, 2 o 3
                // se ejecuta el caso default
                default:
                    Console.WriteLine("Default");
                    break;
            }

        }

        public void EjemploSwitchCase3()
        {
            Console.WriteLine("Elige un tamaño de vaso");
            Console.WriteLine("1=pequeño, 2=mediano, 3=grande");
            Console.Write("Ingresa tu selección: ");
            string str = Console.ReadLine();
            int cost = 0;
            switch (str)
            {
                case "1": // si ingreso 1 
                case "pequeño":
                    cost += 25;
                    break;
                case "2":
                case "mediano":
                    cost += 25;
                    goto case "1";
                case "3":
                case "grande":
                    cost += 50;
                    goto case "1";
                default:
                    Console.WriteLine("Selección no válida");
                    break;
            }
            if (cost != 0)
            {
                Console.WriteLine("El coste es de " + cost + " centavos");
            }
            Console.WriteLine("Disfrute su café");
        }
    }
}
