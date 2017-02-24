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
        [TestMethod]
        public void UsingArrays()
        {
            float[] grades = new float[3];
            AddGradeToArray(grades);
            Assert.AreEqual(89.2f, grades[1]);
        }

        private void AddGradeToArray(float[] grades)
        {
            grades[1] = 89.2f;
        }

        [TestMethod]
        public void UsingLists()
        {
            List<float> grades = new List<float>();
            AddGradeToList(grades);
            Assert.AreEqual(89.2f, grades[0]);
        }

        private void AddGradeToList(List<float> grades)
        {
            grades.Add(89.2f);
        }

        [TestMethod]
        public void UppercaseString()
        {
            string str = "stephen";
            // have to reassign
            str = str.ToUpper();

            Assert.AreEqual("STEPHEN", str);
        }
        [TestMethod]
        public void AddDaysToDateTime()
        {
            DateTime date = new DateTime(2016, 12, 12);
            // have to reassign
            date = date.AddDays(1);

            Assert.AreEqual(13, date.Day);
        }

        [TestMethod]
        public void ValueTypesPassByValue()
        {
            int x1 = 1;
            int x2 = x1;

            IncrementNumber(x2);
            Assert.AreEqual(x1, x2);
        }

        private void IncrementNumber(int x)
        {
            x += 1;
        }

        [TestMethod]
        public void ReferenceTypesPassByValue()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            GiveBookAName(book2);
            Assert.AreEqual("This is a book", book1.Name);
        }

        private void GiveBookAName(GradeBook book)
        {
            book.Name = "This is a book";
        }

        [TestMethod]
        public void StringComparisons()
        {
            string name1 = "Stephen";
            string name2 = "stephen";

            bool result = String.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IntVariablesHoldAValue()
        {
            int x1 = 20;
            int x2 = x1;

            x1 = 50;

            Assert.AreNotEqual(x1, x2);
        }

        [TestMethod]
        public void GradeBookVariablesHoldAReference()
        {
            GradeBook testBook1 = new GradeBook();
            GradeBook testBook2 = testBook1;

            testBook1 = new GradeBook();
            testBook1.Name = "Stephen";

            GradeBook testBook3 = testBook1;
            Assert.AreNotEqual(testBook1.Name, testBook2.Name);
            Assert.AreEqual(testBook1.Name, testBook3.Name);
        }
    }
}
