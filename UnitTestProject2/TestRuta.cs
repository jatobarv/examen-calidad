using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibreriaTaller;

namespace Tests
{
    /// <summary>
    /// Descripción resumida de TestRuta
    /// </summary>
    [TestClass]
    public class TestRuta
    {
        [TestMethod]
        public void TestAgregarRuta()
        {
            // Arrange
            int codigo = 12345;
            string nombre = "Nombre ruta";
            int costoGuia = 20000;
            int costoChofer = 15000;
            int arriendoFurgon = 10000;
            int expected = 1;

            Ruta ruta = new Ruta(codigo, nombre, costoGuia, costoChofer, arriendoFurgon);
            NegocioTurismo NT = new NegocioTurismo();

            // Act
            var actual = NT.AgregarRuta(ruta);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
