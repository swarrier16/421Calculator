using Microsoft.VisualStudio.TestTools.UnitTesting;
using RandomGen;

namespace RandomTests
{
    [TestClass]
    public class RandomTest
    {


        [TestMethod]
        public void GenerateDecimalTest()
        {
            decimal _value = Randos.Generate(6M);

            Assert.AreEqual(0.9M, _value);
        }

        [TestMethod]
        public void DecimalRangeTest()
        {
            decimal _value = Randos.Generate(5M, 0, 100);

            Assert.AreEqual(33.84M, _value);
        }

        [TestMethod]
        public void IntRangeTest()
        {
            int _value = Randos.Generate(5, 0, 100);

            Assert.AreEqual(33, _value);
        }

        [TestMethod]
        public void GenerateIntTest()
        {
            int _value = Randos.Generate(5);

            Assert.AreEqual(726643700, _value);
        }

        [TestMethod]
        public void IntListTest()
        {

            int[] arrayList = { 726643700, 610783965, 564707973, 1342984399, 995276750 };
            int[] _value = Randos.Generate(5, 5);
            CollectionAssert.AreEqual(arrayList, _value);
        }

        [TestMethod]
        public void DecimalListTest()
        {

            decimal[] arrayList = { 0.34M, 0.28M, 0.26M, 0.63M, 0.46M };
            decimal[] _value = Randos.Generate(5M, 5);
            CollectionAssert.AreEqual(arrayList, _value);
        }


    }
}

