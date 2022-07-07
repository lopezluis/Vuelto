using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vuelto;

namespace VueltoTests
{
    [TestClass]
    public class VueltoTests
    {
        [TestMethod]
        public void TesteoVuelto1()
        {
            Vuelto.Aplicacion.Vuelto v1 = new Vuelto.Aplicacion.Vuelto(345.67, 500);
            Assert.AreEqual("Entregar: 1 billete de $100, 1 billete de $50, 8 monedas de $0,50, 3 monedas de $0,10 y 3 monedas de $0,01.", v1.GetImporte(), "El vuelto a entregar, no es correcto.");
        }

        [TestMethod]
        public void TesteoVuelto2()
        {
            Vuelto.Aplicacion.Vuelto v1 = new Vuelto.Aplicacion.Vuelto(157.40, 200);
            Assert.AreEqual("Entregar: 2 billetes de $20, 5 monedas de $0,50 y 1 moneda de $0,10.", v1.GetImporte(), "El vuelto a entregar, no es correcto.");
        }
    }
}