using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Tests
{
    [TestClass()]
    public class UsuarioTests
    {
        [TestMethod()]
        public void RegistrarTest()
        {

            var resultado = Usuario.Registrar("hugo","torrico");
            //Assert: comprobar el valor con el esperado.
            Assert.AreEqual(true,resultado);

        }

        [TestMethod()]
        public void ActualizarTest()
        {
            var resultado = Usuario.Actualizar("hugo", "torrico");
            //Assert: comprobar el valor con el esperado.
            Assert.AreEqual(true, resultado);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            var resultado = Usuario.Eliminar(1);
            //Assert: comprobar el valor con el esperado.
            Assert.AreEqual(true, resultado);
        }
    }
}