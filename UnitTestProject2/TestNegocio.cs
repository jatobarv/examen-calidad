using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibreriaTaller;

namespace Tests
{
    /// <summary>
    /// Descripción resumida de TestNegocio
    /// </summary>
    [TestClass]
    public class TestNegocio
    {
        [TestMethod]
        public void TestAgregarCliente()
        {
            // Arrange
            string rut = "19745041k";
            string name = "Javier";
            string phone = "57739536";
            string mail = "ja.tobarv@alumnos.duoc.cl";

            Cliente cliente = new Cliente(rut, name, phone, mail);
            int expected = 1;
            NegocioTurismo Nt = new NegocioTurismo();

            // Act
            var result = Nt.RegistrarCliente(cliente);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
