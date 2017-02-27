using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void ComputesHighestGrade()
        {
            // Arrange
            GradeBook testBook = new GradeBook();

            // Act
            testBook.AddGrade(55);
            testBook.AddGrade(95);
            testBook.AddGrade(72);
            GradeStatistics testStats = testBook.ComputeStatistics();

            // Assert
            Assert.AreEqual(95, testStats.HighestGrade);

        }

        [TestMethod]
        public void ComputesLowestGrade()
        {
            // Arrange
            GradeBook testBook = new GradeBook();

            // Act
            testBook.AddGrade(55);
            testBook.AddGrade(95);
            testBook.AddGrade(72);
            GradeStatistics testStats = testBook.ComputeStatistics();

            // Assert
            Assert.AreEqual(55, testStats.LowestGrade);

        }

        [TestMethod]
        public void ComputesAverageGrade()
        {
            // Arrange
            GradeBook testBook = new GradeBook();

            // Act
            testBook.AddGrade(55);
            testBook.AddGrade(22.5f);
            testBook.AddGrade(72);
            float testAverage = (55 + 22.5f + 72) / 3;
            GradeStatistics testStats = testBook.ComputeStatistics();

            // Assert
            Assert.AreEqual(testAverage, testStats.AverageGrade);

        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void GradebookNameNull()
        {
            // Arrange
            GradeBook testBook = new GradeBook();

            // Act
            testBook.Name = null;

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void GradebookNameWhiteSpace()
        {
            // Arrange
            GradeBook testBook = new GradeBook();

            // Act
            testBook.Name = "";

            // Assert
            Assert.Fail();
        }
    }
}
