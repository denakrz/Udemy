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
    public class ValoracionesTest // debe ser público para poder acceder
    {
        [TestMethod]
        public void CalcularValoracionMax()
        {
            LibroValoraciones libro = new LibroValoraciones();
            libro.AgregarValoracion(5);
            CalcularValoraciones resultado = libro.PublicarValoraciones();

            Assert.AreEqual(5, resultado.valoracionMax);
        }
        
    }
}
