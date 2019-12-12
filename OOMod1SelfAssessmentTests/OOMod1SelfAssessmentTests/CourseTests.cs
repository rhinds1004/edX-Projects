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
        public void Equals_CheckNullFails_ReturnIsFalse()
        {
            Course testCourse = new Course("blah");
         
            Assert.IsFalse(testCourse.Equals(null));
           
        }

        [TestMethod()]
        public void AddTeacher_EnsureTeacherGetsAddedAsTeacherOfCourse_ReturnIsTrue()
        {
            Teacher testTeacher = new Teacher("Autumn", "Hinds");
            Course testCourse = new Course("Therpy 101");

            Assert.IsTrue(testCourse.AddTeacher(testTeacher));
        }

        [TestMethod()]
        public void IsCourseTeacher_EnsureCourseTeacherIsTheOneExpected_ReturnIsTrue()
        {
            Teacher testTeacher = new Teacher("Autumn", "Hinds");
            Course testCourse = new Course("Therpy 101");

            testCourse.AddTeacher(testTeacher);
            Assert.IsTrue(testCourse.IsCourseTeacher("Autumn", "Hinds"));
        }

        [TestMethod()]
        public void IsCourseTeacher_CheckIfFirstNameIsNull_ReturnIsFalse()
        {
            Teacher testTeacher = new Teacher("Autumn", "Hinds");
            Course testCourse = new Course("Therpy 101");

            testCourse.AddTeacher(testTeacher);
            Assert.IsFalse(testCourse.IsCourseTeacher(null, "Hinds"));
        }

        [TestMethod()]
        public void IsCourseTeacher_CheckIfLastNameIsNull_ReturnIsFalse()
        {
            Teacher testTeacher = new Teacher("Autumn", "Hinds");
            Course testCourse = new Course("Therpy 101");

            testCourse.AddTeacher(testTeacher);
            Assert.IsFalse(testCourse.IsCourseTeacher("Autumn", null));
        }

        [TestMethod()]
        public void GetTeachersOfCourse_Ensure2TeacherGetsAddedAsTeachersOfCourse_ReturnIsTrue()
        {
            Teacher testTeacher = new Teacher("Autumn", "Hinds");
            Teacher testTeacher1 = new Teacher("Jackson", "Hinds");
            Course testCourse = new Course("Therpy 101");

            testCourse.AddTeacher(testTeacher);
            testCourse.AddTeacher(testTeacher1);
            Assert.AreEqual(2, testCourse.GetTeachersOfCourse().Count);
        }

        [TestMethod]
        public void GetTeachersOfCourse_CheckIfTeacherFullNameIsReturnedAreEqual_ReturnIsTrue()
        {
            Teacher testTeacher = new Teacher("Autumn", "Hinds");
            Teacher testTeacher1 = new Teacher("Jackson", "Hinds");
            Course testCourse = new Course("Therpy 101");
            testCourse.AddTeacher(testTeacher);
            testCourse.AddTeacher(testTeacher1);
            Assert.AreEqual("Autumn Hinds", testCourse.GetTeachersOfCourse()[0]);
            Assert.AreEqual("Jackson Hinds", testCourse.GetTeachersOfCourse()[1]);
        }

        [TestMethod]
        public void GetTeachersOfCourse_CheckIfTeacherFullNameReturnedIsOneStringWithSpaceBetweenFirstAndLastName_AreEqualIsTrue()
        {
            Teacher testTeacher = new Teacher("Autumn", "Hinds");

            Course testCourse = new Course("Therpy 101");
            testCourse.AddTeacher(testTeacher);

            Assert.AreEqual("Autumn Hinds", testCourse.GetTeachersOfCourse()[0]);

        }

    }

}