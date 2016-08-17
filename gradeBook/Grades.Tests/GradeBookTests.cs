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
            GradeBook testBook = new GradeBook();

            testBook.AddGrade(55);
            testBook.AddGrade(95);
            testBook.AddGrade(72);

            GradeStatistics testStats = testBook.ComputeStatistics();
            Assert.AreEqual(95, testStats.HighestGrade);

        }

        [TestMethod]
        public void ComputesLowestGrade()
        {
            GradeBook testBook = new GradeBook();

            testBook.AddGrade(55);
            testBook.AddGrade(95);
            testBook.AddGrade(72);

            GradeStatistics testStats = testBook.ComputeStatistics();
            Assert.AreEqual(55, testStats.LowestGrade);

        }

        [TestMethod]
        public void ComputesAverageGrade()
        {
            GradeBook testBook = new GradeBook();

            testBook.AddGrade(55);
            testBook.AddGrade(22.5f);
            testBook.AddGrade(72);

            float testAverage = (55 + 22.5f + 72) / 3;

            GradeStatistics testStats = testBook.ComputeStatistics();
            Assert.AreEqual(testAverage, testStats.AverageGrade);

        }
    }
}
