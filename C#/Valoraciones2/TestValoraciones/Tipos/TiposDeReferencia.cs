using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valoraciones2;

namespace Valoraciones2.TestValoraciones.Tipos
{
    [TestClass]
    public class TiposDeReferencia
    {
        [TestMethod]
        public void VariablesTipoReferencia() // apunta siempre a un espacio de memoria específico.
        {
            LibroValoraciones l1 = new LibroValoraciones();
            l1.Nombre = "Libro Dena";
            LibroValoraciones l2 = l1;
            Assert.AreEqual(l1.Nombre, l2.Nombre);
        }
    }
}
