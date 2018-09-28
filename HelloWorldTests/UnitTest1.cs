using System;
using HelloWorld;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorldTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var printHello = new PrintHello();

            //Act
            var result = printHello.PrintHelloWorld();

            //Assert
            Assert.AreEqual("HelloWorld", result);
        }
    }
}
