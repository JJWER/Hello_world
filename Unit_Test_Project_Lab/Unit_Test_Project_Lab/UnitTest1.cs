using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary; //Add Library
using System;

namespace Unit_Test_Project_Lab
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_Add() {
            //Arrange
            Mymath mymath = new Mymath();

            //Act
            int result = mymath.Add(1, 2);
            //Assert
            Assert.AreEqual(result, 3);
        }
        [TestMethod]
        public void TestMethod_Add2()
        {
            //Arrange
            Mymath mymath = new Mymath();

            //Act
            int result = mymath.Add(1, 2);
            //Assert
            Assert.AreEqual(result, 3);
        }
    }
}
