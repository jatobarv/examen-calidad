using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibreriaTaller;

namespace Tests
{
    /// <summary>
    /// Descripción resumida de TestsEtapa
    /// </summary>
    [TestClass]
    public class TestsEtapa
    {
        [TestMethod]
        public void TestNombre()
        {
            // Arrange
            int codigo = 12345;
            string nombre = "Nombre Etapa";
            string descripcion = "Descripcion";
            int tiempoVisita = 90;
            string expected = "Nombre Etapa";

            Etapa etapa = new Etapa(codigo, nombre, descripcion, tiempoVisita);

            // Act
            string actual = etapa.Nombre;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCodigo()
        {
            // Arrange
            int codigo = 12345;
            string nombre = "Nombre Etapa";
            string descripcion = "Descripcion";
            int tiempoVisita = 90;
            int expected = 12345;

            Etapa etapa = new Etapa(codigo, nombre, descripcion, tiempoVisita);

            // Act
            int actual = etapa.Codigo;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDescripcion()
        {
            // Arrange
            int codigo = 12345;
            string nombre = "Nombre Etapa";
            string descripcion = "Descripcion";
            int tiempoVisita = 90;
            string expected = "Descripcion";

            Etapa etapa = new Etapa(codigo, nombre, descripcion, tiempoVisita);

            // Act
            string actual = etapa.Descripcion;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestTiempoVisita()
        {
            // Arrange
            int codigo = 12345;
            string nombre = "Nombre Etapa";
            string descripcion = "Descripcion";
            int tiempoVisita = 90;
            int expected = 90;

            Etapa etapa = new Etapa(codigo, nombre, descripcion, tiempoVisita);

            // Act
            int actual = etapa.TiempoVisita;

            // Assert
            Assert.AreEqual(expected, actual);
        }
        
    }
}
