using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mathmagician.Tests
{
    [TestClass]
    public class FiboTests
    {
        [TestMethod]
        public void FiboEnsureICanCreateAnInstance()
        {
            Fibo my_fibos = new Fibo();
            Assert.IsNotNull(my_fibos);
        }

        [TestMethod]
        public void FiboEnsureICanGetFirst()
        {
            // Arrange
            Fibo my_fibos = new Fibo();

            // Act
            int actual = my_fibos.GetFirst();
            int expected = 1;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FiboGet4thFiboNumber()
        {
            // Arrange
            Fibo my_fibo = new Fibo();

            // Act
            int actual = my_fibo.GetNth(4);
            int expected = 3;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FiboGet2ndFiboNumber()
        {
            // Arrange
            Fibo my_fibo = new Fibo();

            // Act
            int actual = my_fibo.GetNth(2);
            int expected = 1;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FiboGet9thFiboNumber()
        {
            // Arrange
            Fibo my_fibo = new Fibo();

            // Act
            int actual = my_fibo.GetNth(9);
            int expected = 34;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FiboEnsureICanGetNext()
        {
            // Arrange
            Fibo my_fibos = new Fibo();

            // Act
            int actual = my_fibos.GetNext(8);
            int expected = 13;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FiboEnsureICanCreateASequenceOfTen()
        {
            // Arrange
            Fibo my_fibos = new Fibo();

            // Act
            int[] actual = my_fibos.GetSequence(10);
            int[] expected = new int[] { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void FiboEnsureValidInt()
        {
            // Arrange
            Fibo my_fibos = new Fibo();
            // Act
            my_fibos.GetNth(-1);
            // Assert

        }
    }
}
