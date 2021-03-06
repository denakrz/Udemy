﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valoraciones2;

namespace TestValoraciones
{
    [TestClass]
    public class Test // debe ser público para poder acceder
    {
        [TestMethod]
        public void CalcularValoracionMax()
        {
            LibroValoraciones libro = new LibroValoraciones();
            libro.AgregarValoracion(1.2f); 
            libro.AgregarValoracion(5);
            libro.AgregarValoracion(5);
            libro.AgregarValoracion(3.4f);

            CalcularValoraciones resultado = libro.PublicarValoraciones();

            Assert.AreEqual(5, resultado.ValoracionMax);
        }

        [TestMethod]
        public void CalcularValoracionMin()
        {
            LibroValoraciones libro = new LibroValoraciones();
            libro.AgregarValoracion(1.2f);
            libro.AgregarValoracion(5);
            libro.AgregarValoracion(5);
            libro.AgregarValoracion(3.4f);

            CalcularValoraciones resultado = libro.PublicarValoraciones();

            Assert.AreEqual(1.2f, resultado.ValoracionMin);
        }

        [TestMethod]
        public void CalcularValoracionPromedio()
        {
            LibroValoraciones libro = new LibroValoraciones();
            libro.AgregarValoracion(1.2f);
            libro.AgregarValoracion(5);
            libro.AgregarValoracion(5);
            libro.AgregarValoracion(3.4f);

            CalcularValoraciones resultado = libro.PublicarValoraciones();

            Assert.AreEqual(3.65f, resultado.PromedioValoraciones,0.01);
        }
    }
}
