using System;
using Xunit;
using EjercccioValidacion;

namespace PruebasNombre
{
    public class UnitTest1
    {
        ClaseNombre nom = new ClaseNombre();
        [Fact]
        public void EdadCorrecta() {
            string nombre1 = "Test";
            string nombre2 = "Test";
            string apellidos = "Test";
            string result;
            string resultado = "CORRRECTO";

            result = nom.longnombres(nombre1, nombre2, apellidos);

            Assert.AreEqual(resultado, result);
        }
        [Fact]
        public void EdadIncorrecta()
        {
            string nombre1 = "testtesttesttesttest";
            string nombre2 = "testtesttesttesttesttesttesttesttesttest";
            string apellidos = "testtesttesttesttesttesttesttesttesttesttesttesttesttesttest";
            string result;
            string resultado = "ERROR";

            result = nom.longnombres(nombre1, nombre2, apellidos);
            Assert.Equal(resultado, result);

        }
    }
}
