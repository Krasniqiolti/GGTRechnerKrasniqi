using Microsoft.VisualStudio.TestTools.UnitTesting;
using OMG_Krasniqi_Olti;

namespace GgtTests
{
    [TestClass]
    public class ModelTests
    {
        private Model model;

        [TestInitialize]
        public void Setup()
        {
            model = new Model();
        }

        [TestMethod]
        public void Ggt_WithZeroA_ReturnsB()
        {
            Assert.AreEqual(5, model.Ggt(0, 5));
        }

        [TestMethod]
        public void Ggt_WithZeroB_ReturnsA()
        {
            Assert.AreEqual(7, model.Ggt(7, 0));
        }

        [TestMethod]
        public void Ggt_SameNumbers_ReturnsNumber()
        {
            Assert.AreEqual(6, model.Ggt(6, 6));
        }

        [TestMethod]
        public void Ggt_A_GreaterThanB_ReturnsCorrectGgt()
        {
            Assert.AreEqual(2, model.Ggt(10, 4));
        }

        [TestMethod]
        public void Ggt_A_LessThanB_ReturnsCorrectGgt()
        {
            Assert.AreEqual(2, model.Ggt(4, 10));
        }

        [TestMethod]
        public void Ggt_NegativeNumbers_ReturnsCorrectGgt()
        {
            Assert.AreEqual(4, model.Ggt(-8, 12));
        }

        [TestMethod]
        public void Ggt_PrimeNumbers_Returns1()
        {
            Assert.AreEqual(1, model.Ggt(7, 13));
        }
    }
}
