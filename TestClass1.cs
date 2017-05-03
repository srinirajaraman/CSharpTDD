using NUnit.Framework;

namespace ConsoleApplication2
{
    [TestFixture]
    class TestClass1
    {
        [Test]
        public void DivideTwoNumbers()
        {
            Program sut = new Program();
            int expectedResult = sut.DivideTest(7, 8);
            Assert.That(expectedResult, Is.EqualTo(0));

            int expectedResult1 = sut.DivideTest(9, 8);
            Assert.That(expectedResult1, Is.EqualTo(1));

            int expectedResult2 = sut.DivideTest(8, 8);
            Assert.That(expectedResult2, Is.EqualTo(1));

            int expectedResult3 = sut.DivideTest(8, 0);
            Assert.That(expectedResult3, Is.EqualTo(-1));

            int[] iarray = new int[] { 2, 1, 3 };
            int maxElement1 = sut.GetMax(iarray);
            Assert.That(maxElement1, Is.EqualTo(3));

            int[] iarray1 = new int[] { 1, 5, 9, 2, 3, 7, 8 };
            int maxElement2 = sut.GetMax(iarray);
            Assert.That(maxElement2, Is.EqualTo(9));
        }

    }
}
