using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones2.TestValoraciones.Tipos
{
    [TestClass]
    public class TiposDeValor
    {
        int x;
        float y;
        double z;
        string cadenas;

        [TestMethod]
        public void VariableTiposValorTest()
        {
            int x1 = 10;
            int x2 = x1;

            Assert.AreEqual(x1, x2);
        }

        [TestMethod]
        public void VariablesDesiguales()
        {
            string x3 = "hola";
            string x4 = "chau";

            Assert.AreNotEqual(x3, x4);
        }

        [TestMethod]
        public void IdiomaVariables()
        {
            LibroValoraciones libro = new LibroValoraciones();
            libro.Idioma = IdiomaLibro.ES;

            Assert.AreEqual(libro.Idioma, IdiomaLibro.ES);
        }
        
    }
}
