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
    public class CourseTests
    {
        Student testStudent1;
        Student testStudent2;
        [TestInitialize]
        public void testInit()
        {
            testStudent1 = new Student("Blah", "Blah");
            testStudent2 = new Student("Blah", "Blah");
        }

        [TestCleanup]
        public void testClean()
        {
            testStudent1 = null;
            testStudent2 = null;
        }


        [TestMethod()]
        public void Equals_MakesSureTwoCoursesWithSameNameAreEqual_IsTrue()
        {
            Course testCourse = new Course("blah");
            Course testCourse2 = new Course("blah");
            Assert.IsTrue(testCourse.Equals(testCourse2));
        }

        [TestMethod()]
        public void Equals_MakesSureTwoCoursesWithDifferentNameAreNotEqual_IsFalse()
        {
            Course testCourse = new Course("blah");
            Course testCourse2 = new Course("Notblah");
            Assert.IsFalse(testCourse.Equals(testCourse2));
        }

        [TestMethod()]
        public void AddTeacher_EnsureTeacherGetsAdded_ReturnValueEqualsOne()
        {
            Assert.Fail();
        }


    }

}