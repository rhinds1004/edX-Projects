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
    }
}