using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valoraciones2;

namespace TestValoraciones
{
    [TestClass]
    public class InmutableTest
    {
        [TestMethod]
        public void FailedInmutableTestMethod()
        {
            string nombre = "Dena";
            nombre.ToUpper(); // no funciona porque todas las variables son innimutables

            // Assert.AreEqual("DENA", nombre); -----> fallaría el test
            Assert.AreNotEqual("DENA", nombre);
        }

        [TestMethod]
        public void InmutableTestMethod()
        {
            string nombre = "Dena";
            nombre = nombre.ToUpper();

            Assert.AreEqual("DENA", nombre);

            DateTime fecha = new DateTime(1997, 05, 21);
            fecha = fecha.AddDays(1);

            Assert.AreEqual(22, fecha.Day);
        }

        [TestMethod]
        public void ArrayTestMethod()
        {
            letras = new string[3]; // para agregar datos tengo que usar métodos o bucles.
            AgregarLetra("A");

            Assert.AreEqual("A", letras[0]);
        }

        [TestMethod]
        public void IntTestMethod()
        {
            numReferencia = new int[3];
            numReferencia[0] = 1;
            numReferencia[1] = 2;
            numReferencia[2] = 3;

            int[] numReferencia2 = numReferencia;

            Assert.AreEqual(numReferencia[0], numReferencia2[0]);
        }

        void AgregarLetra(string L)
        {
            letras[0] = L; 
        }

        string[] letras; // lo declaro acá abajo para que esté en contexto
        int[] numReferencia;
    }
}
