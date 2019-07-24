using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomerData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData.Tests
//methods to test the bill charge output for each customer type
{
    [TestClass()]
    public class CustomerTests
    {
        //2 tests for Residential customer type
        [TestMethod()]
        public void TestResidential1()
        {
            //Arrange
            double expected = 110;

            //Act
            Customer ana = new Customer(1, "Ana", 'R', 2000, 0);
            double actual = ana.CalculateCharge();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TestResidential2()
        {
            //Arrange
            double expected = 266;

            //Act
            Customer ana = new Customer(1, "Ana", 'R', 5000, 0);
            double actual = ana.CalculateCharge();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //2 tests for Commercial customer type
        [TestMethod()]
        public void TestCommercial1()
        {
            //Arrange
            double expected = 105;

            //Act
            Customer bob = new Customer(1, "Bob", 'C', 2000, 0);
            double actual = bob.CalculateCharge();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TestCommercial2()
        {
            //Arrange
            double expected = 240;

            //Act
            Customer bob = new Customer(1, "Bob", 'C', 5000, 0);
            double actual = bob.CalculateCharge();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //4 tests for Industrial customer type
        [TestMethod()]
        public void TestIndustrialBothBelow1000()
        {
            //Arrange
            double expected = 116;

            //Act
            Customer cath = new Customer(1, "Cath", 'I', 500, 500);
            double actual = cath.CalculateCharge();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TestIndustrialPeakAbove1000()
        {
            //Arrange
            double expected = 181;

            //Act
            Customer dennis = new Customer(1, "Dennis", 'I', 2000, 0);
            double actual = dennis.CalculateCharge();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TestIndustrialOffPeakAbove1000()
        {
            //Arrange
            double expected = 144;

            //Act
            Customer eric = new Customer(1, "Eric", 'I', 0, 2000);
            double actual = eric.CalculateCharge();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TestIndustrialBothAbove1000()
        {
            //Arrange
            double expected = 209;

            //Act
            Customer farrah = new Customer(1, "Farrah", 'I', 2000, 2000);
            double actual = farrah.CalculateCharge();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
