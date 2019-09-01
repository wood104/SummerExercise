using Microsoft.VisualStudio.TestTools.UnitTesting;
using Summer;
using System.Collections.Generic;
using System.Linq;

namespace SummerTests
{
    [TestClass]
    public class TestSummer
    {
        [TestMethod]
        public void Initialize_With_10()
        {
            //Arrange
            const int limit = 10;
            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //Act
            var exercise = new Exercise();
            var programList = exercise.InitializeList(limit).ToList();

            //Assert
            CollectionAssert.AreEqual(programList, list, "List of numbers is initialized correctly");
        }


        [TestMethod]
        public void FindQuotients_Given_Values()
        {
            //Arrange
            const int limit = 10;

            var exercise = new Exercise();

            var initialList = exercise.InitializeList(limit).ToList();

            var dividendList = new List<int> { 3, 5 };

            //Act
            var quotientList = exercise.FindQuotients(initialList, dividendList).ToList();

            //Assert
            CollectionAssert.AreEqual(quotientList, new List<int> { 3, 5, 6, 9 }, "Expected list of quotients returned");
        }

        [TestMethod]
        public void SumListedIntegers_1_Through_4()
        {
            //Arrange
            var testList = new List<int> { 1, 2, 3, 4 };

            var exercise = new Exercise();

            //Act
            var sum = exercise.SumListedIntegers(testList);

            //Assert
            Assert.AreEqual(sum, 10, "Expeced answer 10");
        }
    }
}
