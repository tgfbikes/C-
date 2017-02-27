using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests.Types
{
    [TestClass]
    public class TypeTests
    {
        private void AddGradeToArray(float[] grades)
        {
            grades[1] = 89.2f;
        }

        private void AddGradeToList(List<float> grades)
        {
            grades.Add(89.2f);
        }

        private void IncrementNumber(int x)
        {
            x += 1;
        }

        private void GiveBookAName(GradeBook book)
        {
            book.Name = "This is a book";
        }

        [TestMethod]
        public void UsingArrays()
        {
            // Arrange
            float[] grades = new float[3];

            // Act
            AddGradeToArray(grades);

            // Assert
            Assert.AreEqual(89.2f, grades[1]);
        }

        [TestMethod]
        public void UsingLists()
        {
            // Arrange
            List<float> grades = new List<float>();

            // Act
            AddGradeToList(grades);
        
            // Assert
            Assert.AreEqual(89.2f, grades[0]);
        }

        [TestMethod]
        public void UppercaseString()
        {
            // Arrange
            string str = "stephen";

            // Act - have to reassign
            str = str.ToUpper();

            // Assert
            Assert.AreEqual("STEPHEN", str);
        }

        [TestMethod]
        public void AddDaysToDateTime()
        {
            // Arrange
            DateTime date = new DateTime(2016, 12, 12);

            // Act - have to reassign
            date = date.AddDays(1);

            // Assert
            Assert.AreEqual(13, date.Day);
        }

        [TestMethod]
        public void ValueTypesPassByValue()
        {
            // Arrange
            int x1 = 1;
            int x2 = x1;

            // Act
            IncrementNumber(x2);

            // Assert
            Assert.AreEqual(x1, x2);
        }


        [TestMethod]
        public void ReferenceTypesPassByValue()
        {
            // Arrange
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            // Act
            GiveBookAName(book2);

            // Assert
            Assert.AreEqual("This is a book", book1.Name);
        }

        [TestMethod]
        public void StringComparisons()
        {
            // Arrange
            string name1 = "Stephen";
            string name2 = "stephen";

            // Act
            bool result = String.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IntVariablesHoldAValue()
        {
            // Arrange
            int x1 = 20;
            int x2 = x1;

            // Act
            x1 = 50;

            // Assert
            Assert.AreNotEqual(x1, x2);
        }

        [TestMethod]
        public void GradeBookVariablesHoldAReference()
        {
            // Arrange
            GradeBook testBook1 = new GradeBook();
            GradeBook testBook2 = testBook1;

            // Act
            testBook1 = new GradeBook();
            testBook1.Name = "Stephen";

            GradeBook testBook3 = testBook1;

            // Assert
            Assert.AreNotEqual(testBook1.Name, testBook2.Name);
            Assert.AreEqual(testBook1.Name, testBook3.Name);
        }
    }
}
