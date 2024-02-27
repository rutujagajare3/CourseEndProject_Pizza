using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassProjectLib;

namespace UnitTestsPizza
{
    [TestClass]
    public class UnitTest1
    {
        Pizza p = new Pizza();

        [TestMethod]
        public void Test1()
        {
            //Assign or Arrange
            int pid = 100;
            string ptype = "Vegetarian Pizza";

            //Act
            string acname = p.display(100);

            //Assert

            Assert.AreEqual(ptype, acname);
        }
        [TestMethod]
        public void Test2()
        {

            //Assign or Arrange
            int pid = 101;
            string ptype = "Margherita";

            //Act
            string acname = p.display(101);

            //Assert

            Assert.AreEqual(ptype, acname);
        }
        [TestMethod]
        public void Test3()
        {
            //Assign or Arrange
            int pid = 101;
            string ptype = "Margherita";

            //Act
            string acname = p.display(101);

            //Assert

            Assert.AreEqual(ptype, acname);
        }

    }
}

