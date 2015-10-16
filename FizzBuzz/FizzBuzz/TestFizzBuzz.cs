using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    [TestFixture]
    class TestFizzBuzz
    {
        private FizzBuzz TestInstance;
        private int LowerBound;
        private int UpperBound;
        [SetUp]
        public void Init()
        {
            TestInstance = new FizzBuzz();

            LowerBound = 1;
            UpperBound = 20;
        }
        [Test]
        public void TestGetFizzBuzz()
        {
            List<string> actualResults = TestInstance.GetFizzBuzz(LowerBound, UpperBound);

            Assert.AreEqual("Fizz", actualResults[2]);
            Assert.AreEqual("Buzz", actualResults[4]);
            Assert.AreEqual("FizzBuzz", actualResults[14]);
        }
        [Test]
        public void TestGetCustom()
        {
            TestInstance.SetCustom(2, "Clear");
            TestInstance.SetCustom(5, "Measure");

            List<string> actualResults = TestInstance.GetCustom(LowerBound, UpperBound);

            Assert.AreEqual("Clear", actualResults[1]);
            Assert.AreEqual("Measure", actualResults[4]);
            Assert.AreEqual("Clear", actualResults[3]);
            Assert.AreEqual("ClearMeasure", actualResults[9]);
        }
    }
}
