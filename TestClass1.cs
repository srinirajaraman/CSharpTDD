using NUnit.Framework;

namespace ConsoleApplication2
{
    [TestFixture]
    class TestClass1
    {
        Program obj = new Program();
		
		//Test cases for Dividing 2 numbers
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
		
		//Test cases for getting max element in an array
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
		
		//Test cases for searching an element in a sorted array using Binary search
		[Test]
        public void BinarySearch()
        {
            int[] iarray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            bool iterRecur = true;
            int maxElement1 = obj.BinarySearch(iarray, 8, iterRecur);
            Assert.That(maxElement1, Is.EqualTo(iarray.Length - 1));
        }
		
		//Test cases for searching an element in a sorted array using Linear search
        [Test]
        public void LinearSearch()
        {
            int[] iarray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            bool maxElement1 = obj.LinearSearch(iarray, 8);
            Assert.That(maxElement1, Is.EqualTo(true));
        }
		
		//Test cases to compute max 1's in an array
        [Test]
        public void GetConsectiveOnesTest()
        {
            int[] arr1 = { 1, 1, 0, 1, 1, 1, 1, 1, 0, 1, 1, 0, 1, 1 };
            int maxCount1 = obj.GetConsecutiveOnes(arr1);
            Assert.That(maxCount1, Is.EqualTo(5));
        }
        [Test]
        public void GetConsectiveOnesTest1()
        {
            int[] arr3 = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            int maxCount2 = obj.GetConsecutiveOnes(arr3);
            Assert.That(maxCount2, Is.EqualTo(arr3.Length));
        }
        [Test]
        public void GetConsectiveOnesTest2()
        {
            int[] arr4 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int maxCount4 = obj.GetConsecutiveOnes(arr4);
            Assert.That(maxCount4, Is.EqualTo(0));
        }
        [Test]
        public void GetConsectiveOnesTest3()
        {
            int[] arr5 = { 0, 0, 0, 0, 0, 0, 1, 1, 1, 1 };
            int maxCount5 = obj.GetConsecutiveOnes(arr5);
            Assert.That(maxCount5, Is.EqualTo(4));
        }
		
		 //Check if the string is a palindrome
        [Test]
        public void PalindromeTest()
        {
            string str = "RadAr";
            bool result = obj.PalindromeCheck(str);
            Assert.That(result, Is.EqualTo(true));
        }
        [Test]
        public void PalindromeTest1()
        {
            string str = "AAbbCCbbaa";
            bool result = obj.PalindromeCheck(str);
            Assert.That(result, Is.EqualTo(true));
        }
        [Test]
        public void PalindromeTest2()
        {
            string str = "ABBHHTR";
            bool result = obj.PalindromeCheck(str);
            Assert.That(result, Is.EqualTo(false));
        }
    }
}
