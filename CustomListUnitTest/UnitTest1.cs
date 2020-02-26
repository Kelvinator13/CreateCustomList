using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_OnePositiveInteger_ZeroIndex()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 7;
            int expected = 7;
            int actual;
            //act

            myList.Add(value);
            actual = myList[0];

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Add_NegativeNumber_ZeroIndex()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value2 = -1;
            int expected = -1;
            int actual;
            //act
            myList.Add(value2);
            actual = myList[0];

            //assert

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_DecimalInteger_ZeroIndex()
        {
            //Arrange
            CustomList<double> myList = new CustomList<double>();
            double value3 = 0.5;
            Double expected = 0.5;
            double actual;
            //Act
            myList.Add(value3);
            actual = myList[0];

            //Assert
            Assert.AreEqual(expected, actual);



        }
        [TestMethod]
        public void Add_OrganizeThreeNumbers_ZeroIndex()
        {
            CustomList<int> myList = new CustomList<int>();
            int value4 = 4;
            int value5 = 6;
            int value6 = 8;
            int actual;

            //Act
            myList.Add(value4);
            myList.Add(value5);
            myList.Add(value6);
            actual = myList[0];

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Add_ConsecutiveInteger_ZeroIndex()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int[] arr = {4};
            int value7 = 22222;
            int expected = 22222;
            int actual;

            //Act
            myList.Add(value7);
            myList.Add(value7);
            myList.Add(value7);
            myList.Add(value7);
            myList.Add(value7);
            actual = myList[0];

            //Assert
            Assert.AreEqual(expected, actual);

        }

        public void Remove_Consecutive

    }
}
