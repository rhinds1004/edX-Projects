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
    public class StudentTests
    {
        Student testStudent1;
        Student testStudent2;

        public void testInit()
        {
            // testStudent1 = new Student("Robert", "Hinds");
            //  testStudent2 = new Student("Blah", "Blah");
        }

        [TestCleanup]
        public void testClean()
        {
            // testStudent1 = null;
            // testStudent2 = null;
        }

        [TestMethod()]
        public void StudentCount_SeeIfCounterIncrements_EqualReturnValue()
        {
            Student.StudentCount = 0;
            testStudent1 = new Student("Robert", "Hinds");
            testStudent2 = new Student("Blah", "Blah");
            Assert.AreEqual(2, Student.StudentCount);
        }

        [TestMethod()]
        public void Equals_MakesSureTwoStudentsWithSameNameAreEqual_IsTrue()
        {
            Student testStudent1 = new Student("Autumn", "Hinds");
            Student testStudent2 = new Student("Autumn", "Hinds");

            Assert.IsTrue(testStudent1.Equals(testStudent2));
        }

        [TestMethod()]
        public void Equals_MakesSureTwoStudentsWithDifferentLastNameAreNotEqual_IsFalse()
        {
            Student testStudent1 = new Student("Autumn", "Black");
            Student testStudent2 = new Student("Autumn", "Hinds");

            Assert.IsFalse(testStudent1.Equals(testStudent2));
        }

        [TestMethod()]
        public void Equals_MakesSureTwoStudentsWithDifferentFirstNameAreNotEqual_IsFalse()
        {
            Student testStudent1 = new Student("Jackson", "Hinds");
            Student testStudent2 = new Student("Autumn", "Hinds");

            Assert.IsFalse(testStudent1.Equals(testStudent2));
        }

        [TestMethod()]
        public void Equals_MakesSureNull_IsFalse()
        {
            Student testStudent1 = new Student("Jackson", "Hinds");
            Student testStudent2 = new Student("Autumn", "Hinds");

            Assert.IsFalse(testStudent1.Equals(null));
        }

        [TestMethod()]
        public void OperatorDoubleEquals_MakesSureTwoStudentsWithSameNameAreEqual_IsTrue()
        {
            Student testStudent1 = new Student("Autumn", "Hinds");
            Student testStudent2 = new Student("Autumn", "Hinds");

            Assert.IsTrue(testStudent1 == testStudent2);
        }

        [TestMethod()]
        public void OperatorDoubleEquals_MakesSureTwoStudentsWithDifferentFirstNameAreNotEqual_IsFalse()
        {
            Student testStudent1 = new Student("Jackson", "Hinds");
            Student testStudent2 = new Student("Autumn", "Hinds");

            Assert.IsFalse(testStudent1 == testStudent2);
        }

        [TestMethod()]
        public void OperatorDoubleEquals_MakesSureNull_IsFalse()
        {
            Student testStudent1 = new Student("Jackson", "Hinds");
            Student testStudent2 = new Student("Autumn", "Hinds");

            Assert.IsFalse(null == testStudent2);
        }

        [TestMethod()]
        public void OperatorDoubleEquals_MakesBothNull_IsFalse()
        {
            Student testStudent1 = null;
            Student testStudent2 = null;

            Assert.IsFalse(testStudent1 == testStudent2);
        }


        [TestMethod()]
        public void OperatorNotEqual_MakesSureTwoStudentsWithSameNameAreEqual_IsFalse()
        {
            Student testStudent1 = new Student("Autumn", "Hinds");
            Student testStudent2 = new Student("Autumn", "Hinds");

            Assert.IsFalse(testStudent1 != testStudent2);
        }

        [TestMethod()]
        public void OperatorNotEqual_MakesSureTwoStudentsWithDifferentFirstNameAreNotEqual_IsTrue()
        {
            Student testStudent1 = new Student("Jackson", "Hinds");
            Student testStudent2 = new Student("Autumn", "Hinds");

            Assert.IsTrue(testStudent1 != testStudent2);
        }

        [TestMethod()]
        public void OperatorNotEqual_MakesSureNull_IsTrue()
        {
            Student testStudent1 = new Student("Jackson", "Hinds");
            Student testStudent2 = new Student("Autumn", "Hinds");

            Assert.IsTrue(null != testStudent2);
        }

        [TestMethod()]
        public void OperatorNotEqual_MakesBothNull_IsTrue()
        {
            Student testStudent1 = null;
            Student testStudent2 = null;

            Assert.IsTrue(testStudent1 != testStudent2);
        }

        [TestMethod()]
        public void AddEnrolledCourseTest()
        {
            Student testStudent1 = new Student("Jackson", "Hinds");
            Course myCourse = new Course("Programming 101");
            testStudent1.AddEnrolledCourse(myCourse);
            Assert.IsTrue(testStudent1.EnrolledCourses.Contains(myCourse));
        }
    }
}