using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFirstApplication;

namespace MyFirstTestProject
{
    [TestClass]
    public class Lesson10Test
    {
        [TestMethod]
        public void FirstName_LastName_ZipCode_Verify()
        {
            // Arrange
            string firstName = "George";
            string lastName = "Washington";
            int zipcode = 64119;
            Lesson10 myLesson10 = new Lesson10(firstName, lastName, zipcode);

            // Act - Nothing for this one

            // Assert
            Assert.AreEqual(firstName, myLesson10.FirstName);
            Assert.AreEqual(lastName, myLesson10.LastName);
            Assert.AreEqual(zipcode, myLesson10.Zipcode);

        }
    }
}