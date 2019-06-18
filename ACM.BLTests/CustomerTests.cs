using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void calculatePercentOfGoalStepsTestValid()
        {
            // Arrange
            var customer = new Customer();
            string goalSteps = "5000";
            string actualSteps = "2000";
            decimal expected = 40M;

            //Act
            var actual = customer.calculatePercentOfGoalSteps(goalSteps, actualSteps);

            //Assert
            Assert.AreEqual(expected, actual);
        } 


        [TestMethod]
        public void calculatePercentOfGoalStepsTestValidAndSame()
        {
            // Arrange
            var customer = new Customer();
            string goalSteps = "5000";
            string actualSteps = "5000";
            decimal expected = 100M;

            //Act
            var actual = customer.calculatePercentOfGoalSteps(goalSteps, actualSteps);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void calculatePercentOfGoalStepsTestValidActualIsZero()
        {
            // Arrange
            var customer = new Customer();
            string goalSteps = "5000";
            string actualSteps = "0";
            decimal expected = 0M;

            //Act
            var actual = customer.calculatePercentOfGoalSteps(goalSteps, actualSteps);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void calculatePercentOfGoalStepsGoalIsNull()
        {

            // Arrange
            var customer = new Customer();
            string goalSteps = null;
            string actualSteps = "2000";

            //Act
            var actual = customer.calculatePercentOfGoalSteps(goalSteps, actualSteps);

            //Assert

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void calculatePercentOfGoalStepsGoalIsNullIsNotNumeric()
        {

            // Arrange
            var customer = new Customer();
            string goalSteps = "one";
            string actualSteps = "2000";

            //Act
            try
            {
            var actual = customer.calculatePercentOfGoalSteps(goalSteps, actualSteps);

            }
            catch (Exception ex)
            {
                Assert.AreEqual("Goal must be numeric", ex.Message);
                throw;
            }
             
            //Assert

        }
    }
}
