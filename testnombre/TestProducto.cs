using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjercicioValidacion1;

namespace testproducto
{
    [TestClass]
    public class TestProducto
    {
        ClassProducto pro = new ClassProducto();

        [TestMethod]
        public void DatosCorrecta()
        {
            string codigo ="1234567890";
            
            string result;
            string resultado = "CORRRECTO";

            result = pro.longcodigo(codigo);

            Assert.AreEqual(resultado, result);
        }

        [TestMethod]
        public void DatosIncorrecta()
        {
            string codigo = "12345678901";

            string result;

            string resultado = "ERROR";

            result = pro.longcodigo(codigo);
            Assert.AreEqual(resultado, result);
        }
    }
}
