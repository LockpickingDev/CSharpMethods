using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpMethods;

namespace CSharpMethodsTests
{
    [TestClass]
    public class StringsTests
    {

        #region ReverseString
        //MethodName_Scenario_ExpectedBehavior
        [TestMethod]
        public void ReverseString_ReverseSuccess_ReturnStringReversed() //Valid input
        {
            //Arrange - Initializes objects and sets value of the data that is passed to method under test
            var stringClass = new Strings();
            string userString = "abcd 1234_!";
            string correctOutput = "!_4321 dcba";

            //Act - Invokes the method under test with the arranged parameters
            var result = stringClass.ReverseString(userString);

            //Assert - Verifies that the action of the method under test behaves as expected
            Assert.AreEqual(result, correctOutput);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ReverseString_StringNull_ThrowException() //Guard clause
        {
            //Arrange
            var stringClass = new Strings();
            string userString = null;

            //Act
            //Expecting a specific message from the Guard Clause testing.  If no specific message, just call the MethodTesting
            try
            {
                var result = stringClass.ReverseString(userString);
            }
            catch(Exception ex)
            {
                Assert.AreEqual(ex.Message, "A string must be passed to be reversed.");
                throw; //Catch block just caught the Exception.  We must rethrow the Exception for this method since [ExpectedException]
            }

            //Assert
            //ExpectedException attribute will automatically handle the Assertion for us if that Exception is not generated
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ReverseString_StringEmpty_ThrowException() //Guard clause
        {
            //Arrange
            var stringClass = new Strings();
            string userString = "";

            //Act
            //Expecting a specific message from the Guard Clause testing
            try
            {
                var result = stringClass.ReverseString(userString);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "A string must be passed to be reversed.");
                throw; //Catch block just caught the Exception.  We must rethrow the Exception for this method since [ExpectedException]
            }

            //Assert
            //ExpectedException attribute will automatically handle the Assertion for us if that Exception is not generated
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ReverseString_StringWhiteSpace_ThrowException() //Guard clause
        {
            //Arrange
            var stringClass = new Strings();
            string userString = "";

            //Act
            //Expecting a specific message from the Guard Clause testing
            try
            {
                var result = stringClass.ReverseString(userString);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "A string must be passed to be reversed.");
                throw; //Catch block just caught the Exception.  We must rethrow the Exception for this method since [ExpectedException]
            }

            //Assert
            //ExpectedException attribute will automatically handle the Assertion for us if that Exception is not generated
        }
        #endregion


        #region placeholder

        #endregion


        #region placeholder

        #endregion


        #region placeholder

        #endregion




    }
}
