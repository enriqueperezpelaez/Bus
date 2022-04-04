using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RedTransporte.Class;

namespace BusTest
{
    [TestClass]
    public class MultigrafoTest
    {
        [TestMethod]
        public void addArcoOutOfIndex()
        {
            Multigrafo g = new Multigrafo(3);
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => g.addArco(1, 4, 2));
        }

        [TestMethod]
        public void setArcoPrioritarioNotExist()
        {
            Multigrafo g = new Multigrafo(3);
            Assert.ThrowsException<System.ArgumentException>(() => g.setArcoPrioritario(1,2,3));
        }

        [TestMethod]
        public void getDistanciaOptimaArco()
        {
            Multigrafo g = new Multigrafo(3);
            g.addArco(1, 2,5);
            g.addArco(1, 2, 3);
            g.addArco(1, 2, 6);
            float? esperado = 3;
            float? actual = g.getDistancia(1, 2, true);
            Assert.AreEqual(esperado, actual,"No es el valor esperado");
        }

        [TestMethod]
        public void getDistanciaPrioritariaArco()
        {
            Multigrafo g = new Multigrafo(3);
            g.addArco(1, 2, 5);
            g.addArco(1, 2, 3);
            g.addArco(1, 2, 6);
            g.setArcoPrioritario(1, 2, 5);
            float? esperado = 5;
            float? actual = g.getDistancia(1, 2);
            Assert.AreEqual(esperado, actual, "No es el valor esperado");
        }
    }
}
