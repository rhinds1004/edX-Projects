using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOMod1SelfAssessment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOMod1SelfAssessment.Tests
{
    [TestClass()]
    public class DegreeTests
    {
        private Course testCourse1;

        [TestInitialize]
        public void testInit()
        {
            testCourse1 = new Course("Math 101");
        }

        [TestCleanup]
        public void testClean()
        {
            testCourse1 = null;
        }

        [TestMethod()]
        public void AddCourse_CheckIfCorrectClassWasAdded_ReturnValueEqualsOne()
        {
            Degree coursesList = new Degree("MATH");
            coursesList.AddCourse(testCourse1);
            Assert.AreEqual(1, coursesList.CourseCount());
        }

        [TestMethod()]
        public void AddCourse_CheckIfAddedCourseCanBeFound_CourseCanBeFoundByNameIsTrue()
        {
            Degree coursesList = new Degree("MATH");
            coursesList.AddCourse(testCourse1);
            Assert.IsTrue(coursesList.CheckForCourseByName("Math 101"));
        }
    }
}