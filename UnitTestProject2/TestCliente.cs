using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibreriaTaller;


namespace Tests
{
    [TestClass]
    public class TestCliente
    {

        [TestMethod]
        public void TestRutFalso()
        {
            // Arrange
            string name = "Pepito";
            string rut = "12345";
            string phone = "12345678";
            string mail = "correo@alumnos.duoc.cl";
            Cliente user = new Cliente(rut, name, phone, mail);
            string expected = "12345";

            // Act
            string actual = user.Rut;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestNombre()
        {   
            // Arrange
            string name = "Pepito";
            string rut = "205314288";
            string phone = "12345678";
            string mail = "correo@alumnos.duoc.cl";
            Cliente user = new Cliente(rut, name, phone, mail);
            string expected = "Pepito";

            // Act
            string actual = user.Nombre;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestRut(){
            // Arrange
            string name = "Pepito";
            string rut = "205314288";
            string phone = "12345678";
            string mail = "correo@alumnos.duoc.cl";
            Cliente user = new Cliente(rut, name, phone, mail);
            string expected = "205314288";

            // Act
            string actual = user.Rut;

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestPhone()
        {
            // Arrange
            string name = "Pepito";
            string rut = "205314288";
            string phone = "12345678";
            string mail = "correo@alumnos.duoc.cl";
            Cliente user = new Cliente(rut, name, phone, mail);
            string expected = "12345678";

            // Act
            string actual = user.Telefono;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMail()
        {
            // Arrange
            string name = "Pepito";
            string rut = "205314288";
            string phone = "12345678";
            string mail = "correo@alumnos.duoc.cl";
            Cliente user = new Cliente(rut, name, phone, mail);
            string expected = "correo@alumnos.duoc.cl";

            // Act
            var actual = user.Email;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestValidarEmail()
        {
            // Arrange
            string name = "Pepito";
            string rut = "205314288";
            string phone = "12345678";
            string mailPrueba = "correo@alumnos.duoc.cl";
            Cliente user = new Cliente(rut, name, phone, mailPrueba);
            bool expected = true;

            // Act
            var actual = user.validarEmail(mailPrueba);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
