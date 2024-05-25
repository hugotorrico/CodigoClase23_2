using Calculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{

    [TestClass]
    public class UnitTestOperaciones
    {
       [TestMethod]
        public void TestSumar()
        {
            //Arrange : Inicializar las variables
            int sumando1 = 2;
            int sumando2 = 3;

            //Act : llamar al metodo a testear
            int resultado = Operaciones.Sumar(sumando1, sumando2);

            //Assert: comprobar el valor con el esperado.
            Assert.AreEqual(5, resultado);
        }

        [TestMethod]
        public void TestRestar()
        {
            //Arrange : Inicializar las variables
            int valor1 = 5;
            int valor2 = 2;

            //Act : llamar al metodo a testear
            int resultado = Operaciones.Restar(valor1, valor2);

            //Assert: comprobar el valor con el esperado.
            Assert.AreEqual(3, resultado);
        }
    }
}
