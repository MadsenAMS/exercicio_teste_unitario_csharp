using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace unitTestExercise.Tests
{
    [TestClass()]
    public class DummyClassTests
    {
        [TestMethod()]
        public void PresentYourselfTest()
        {
            //arrange
            string name = "Sebastian";
            string expectedOutput = "My name is Sebastian. Am I a dummy? Well: True";

            //act
            DummyClass dummy = new DummyClass(name);

            //assert
            Assert.AreEqual(expectedOutput, dummy.PresentYourself());
        }
    }
}