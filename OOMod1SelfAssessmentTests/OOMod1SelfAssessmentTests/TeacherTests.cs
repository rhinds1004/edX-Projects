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
    public class TeacherTests
    {

        [TestMethod()]
        public void Equals_MakesSureTwoTeachersWithSameNameAreEqual_IsTrue()
        {
            Teacher testTeacher1 = new Teacher("Autumn", "Hinds");
            Teacher testTeacher2 = new Teacher("Autumn", "Hinds");

            Assert.IsTrue(testTeacher1.Equals(testTeacher2));
        }

        [TestMethod()]
        public void Equals_MakesSureTwoTeachersWithDifferentLastNameAreNotEqual_IsFalse()
        {
            Teacher testTeacher1 = new Teacher("Autumn", "Black");
            Teacher testTeacher2 = new Teacher("Autumn", "Hinds");

            Assert.IsFalse(testTeacher1.Equals(testTeacher2));
        }

        [TestMethod()]
        public void Equals_MakesSureTwoTeachersWithDifferentFirstNameAreNotEqual_IsFalse()
        {
            Teacher testTeacher1 = new Teacher("Jackson", "Hinds");
            Teacher testTeacher2 = new Teacher("Autumn", "Hinds");

            Assert.IsFalse(testTeacher1.Equals(testTeacher2));
        }

        [TestMethod()]
        public void Equals_MakesSureNull_IsFalse()
        {
            Teacher testTeacher1 = new Teacher("Jackson", "Hinds");
            Teacher testTeacher2 = new Teacher("Autumn", "Hinds");

            Assert.IsFalse(testTeacher1.Equals(null));
        }

        [TestMethod()]
        public void OperatorDoubleEquals_MakesSureTwoTeachersWithSameNameAreEqual_IsTrue()
        {
            Teacher testTeacher1 = new Teacher("Autumn", "Hinds");
            Teacher testTeacher2 = new Teacher("Autumn", "Hinds");

            Assert.IsTrue(testTeacher1 == testTeacher2);
        }

        [TestMethod()]
        public void OperatorDoubleEquals_MakesSureTwoTeachersWithDifferentFirstNameAreNotEqual_IsFalse()
        {
            Teacher testTeacher1 = new Teacher("Jackson", "Hinds");
            Teacher testTeacher2 = new Teacher("Autumn", "Hinds");

            Assert.IsFalse(testTeacher1 == testTeacher2);
        }

        [TestMethod()]
        public void OperatorDoubleEquals_MakesSureNull_IsFalse()
        {
            Teacher testTeacher1 = new Teacher("Jackson", "Hinds");
            Teacher testTeacher2 = new Teacher("Autumn", "Hinds");

            Assert.IsFalse(null == testTeacher2);
        }

        [TestMethod()]
        public void OperatorDoubleEquals_MakesBothNull_IsFalse()
        {
            Teacher testTeacher1 = null;
            Teacher testTeacher2 = null;

            Assert.IsFalse(testTeacher1 == testTeacher2);
        }


        [TestMethod()]
        public void OperatorNotEqual_MakesSureTwoTeachersWithSameNameAreEqual_IsFalse()
        {
            Teacher testTeacher1 = new Teacher("Autumn", "Hinds");
            Teacher testTeacher2 = new Teacher("Autumn", "Hinds");

            Assert.IsFalse(testTeacher1 != testTeacher2);
        }

        [TestMethod()]
        public void OperatorNotEqual_MakesSureTwoTeachersWithDifferentFirstNameAreNotEqual_IsTrue()
        {
            Teacher testTeacher1 = new Teacher("Jackson", "Hinds");
            Teacher testTeacher2 = new Teacher("Autumn", "Hinds");

            Assert.IsTrue(testTeacher1 != testTeacher2);
        }

        [TestMethod()]
        public void OperatorNotEqual_MakesSureNull_IsTrue()
        {
            Teacher testTeacher1 = new Teacher("Jackson", "Hinds");
            Teacher testTeacher2 = new Teacher("Autumn", "Hinds");

            Assert.IsTrue(null != testTeacher2);
        }

        [TestMethod()]
        public void OperatorNotEqual_MakesBothNull_IsTrue()
        {
            Teacher testTeacher1 = null;
            Teacher testTeacher2 = null;

            Assert.IsTrue(testTeacher1 != testTeacher2);
        }

        [TestMethod()]
        public void GradeTestTest()
        {
            Teacher testTeacher1 = new Teacher("Jackson", "Hinds");
            Assert.AreEqual(89.0f, testTeacher1.GradeTest("test1"));
        }
    }
}