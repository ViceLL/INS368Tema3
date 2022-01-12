using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PracticaWebApp.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void validate_area_of_triangle_detect_correct_result()
        {
            //Arrange
            int x = 12;
            int y = 8;
            int expected = 48;

            //Act
            double actual = MyWebServices.CalcularAreaDeTriangulo(x, y);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void validate_area_of_square_detect_correct_result()
        {
            //Arrange
            int x = 4;
            int y = 8;
            int expected = 32;

            //Act
            int actual = MyWebServices.CalcularAreaDeCuadrado(x, y);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void validate_area_of_circle_detect_correct_result()
        {
            //Arrange
            int r = 3;
            int expected = 28;

            //Act
            int actual = MyWebServices.CalcularAreaDeCirculo(r);

            //Assert
            Assert.AreEqual(expected, actual);

        }

    }
}
