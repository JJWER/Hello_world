using Microsoft.VisualStudio.TestTools.UnitTesting;
using My_library;
using System;

namespace LABUnitTestProject
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void Test_Assignment_1()
        {
            //ข้อ 1 
            AssignmentClass ac = new AssignmentClass();
            int input = 1020;
            string result = ac.gradeCalculate(input);
            Assert.AreEqual("A", result);
            result = ac.gradeCalculate(80);
            Assert.AreEqual("A", result);
            result = ac.gradeCalculate(-1);
            Assert.AreEqual("F", result);
            result = ac.gradeCalculate(79);
            Assert.AreEqual("B+", result);
            result = ac.gradeCalculate(49);
            Assert.AreEqual("F", result);

        }
        [TestMethod]
        public void Test_Assignment_2()
        {
            //ข้อ 2 
            AssignmentClass ac = new AssignmentClass();
            double result = ac.getDistance(3, 2, 7, 8);
            Assert.AreEqual(7.21, result);
            result = ac.getDistance(-3, 2, 7, -8);
            Assert.AreEqual(14.14, result);
            result = ac.getDistance(-3, -2, -7, -8);
            Assert.AreEqual(7.21, result);
            result = ac.getDistance(3, -2, -7, 8);
            Assert.AreEqual(14.14, result);
        }
        [TestMethod]
        public void Test_Assignment_3()
        {
            /// ข้อ 3 
            AssignmentClass ac = new AssignmentClass();
            int n = ac.getFactorial(5);
            Assert.AreEqual(120, n);
            n = ac.getFactorial(1);
            Assert.AreEqual(1, n);
            n = ac.getFactorial(0);
            Assert.AreEqual(1, n);
            n = ac.getFactorial(-1);
            Assert.AreEqual(1, n);
        }
        [TestMethod]
        public void Test_Assignment_4()
        {
            /// ข้อ 4
            AssignmentClass ac = new AssignmentClass();
            string password = ac.cheackPassword("abc123");
            Assert.AreEqual("false", password);
            password = ac.cheackPassword("abc12345");
            Assert.AreEqual("true", password);
            password = ac.cheackPassword("abcdefgh");
            Assert.AreEqual("false", password);
            password = ac.cheackPassword("12345678");
            Assert.AreEqual("false", password);
        }
    }
}
