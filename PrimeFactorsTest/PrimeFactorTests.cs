using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeFactorsKata;

namespace PrimeFactorsTest
{
    [TestClass]
    public class PrimeFactorTests
    {
        private PrimeFactor primeFactor;

        public PrimeFactorTests()
        {
            primeFactor = new PrimeFactor();
        }

        [TestMethod]
        public void GenerateWithOneReturnsNull()
        {
            Assert.IsNull(primeFactor.Generate(1));
        }

        [TestMethod]
        public void GenerateWithTwoReturnsTwo()
        {
            CollectionAssert.AreEqual(new[] { 2 }, primeFactor.Generate(2));
        }

        [TestMethod]
        public void GenerateWithThreeReturnsThree()
        {
            CollectionAssert.AreEqual(new[] { 3 }, primeFactor.Generate(3));
        }

        [TestMethod]
        public void GenerateWithFourReturnsTwoTwo()
        {
            CollectionAssert.AreEqual(new[] { 2, 2 }, primeFactor.Generate(4));
        }

        [TestMethod]
        public void GenerateWithSixReturnsTwoThree()
        {
            CollectionAssert.AreEqual(new[] { 2, 3 }, primeFactor.Generate(6));
        }

        [TestMethod]
        public void GenerateWithEightReturnsTwoTwoTwo()
        {
            CollectionAssert.AreEqual(new[] { 2, 2, 2 }, primeFactor.Generate(8));
        }
    }
}
