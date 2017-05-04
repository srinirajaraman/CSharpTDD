﻿using NUnit.Framework;

namespace ConsoleApplication2
{
    [TestFixture]
    class TestClass1
    {
        Program obj = new Program();
        [Test]
        public void DivideTwoNumbers()
        {
            int expectedResult = obj.DivideTest(8, 1);
            Assert.That(expectedResult, Is.EqualTo(8));
        }
        [Test]
        public void DivideTwoNumbers1()
        {
            int expectedResult = obj.DivideTest(18, 9);
            Assert.That(expectedResult, Is.EqualTo(2));
        }
        [Test]
        public void DivideTwoNumbers2()
        {
            int expectedResult = obj.DivideTest(8, 0);
            Assert.That(expectedResult, Is.EqualTo(-1));
        }
        [Test]
        public void GetMaxElement()
        {
            int[] iarray = new int[] { 2, 1, 3 };
            int maxElement1 = obj.GetMax(iarray);
            Assert.That(maxElement1, Is.EqualTo(3));
        }
        [Test]
        public void GetMaxElement1()
        {
            int[] iarray = new int[] { 7, 3, 5, 1, 6 };
            int maxElement1 = obj.GetMax(iarray);
            Assert.That(maxElement1, Is.EqualTo(7));
        }

        [Test]
        public void GetMaxElement2()
        {
            int[] iarray = new int[] { 9 };
            int maxElement1 = obj.GetMax(iarray);
            Assert.That(maxElement1, Is.EqualTo(9));
        }
        
    }
}
