using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System.Collections.Generic;

namespace TestsTrabajoPractico3
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// testea que la cantidad de paises que agrega a la lista la funcion de Hardcodeo sea la correcta y no haya perdida de informacion.
        /// </summary>
        [TestMethod]
        public void TestCantidadPaises()
        {
            //Arrange
            List<Pais> paises = Pais.HardcodeoPaises();
            //Act

            //Assert
            Assert.AreEqual(19, paises.Count);
        }
        /// <summary>
        /// Testea que la funcionalidad en la implementacion de la Excepcion este bien realizada cuando se ingresa una extension de archivo invalida.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(InvalidExtensionException))]
        public void TestExtensionInvalida()
        {
            //Arrange
            Pais argentina = new Pais(43600000, false, 2780400, EContinente.America, EIdioma.Spanish, EIndiceDesarrolloHumano.Medio, "Argentina");
            Serializador<Pais> pais = new Serializador<Pais>((IArchivos<Pais>.ETipoArchivo.JSON));
            //Act
            pais.Escribir(argentina, "archivo.txt");
        }
    }
}
