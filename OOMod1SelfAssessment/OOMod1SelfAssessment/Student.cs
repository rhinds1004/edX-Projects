using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOMod1SelfAssessment
{
    public class Student : Person
    {
        public static int StudentCount { get; set; } = 0;

        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            StudentCount++;
        }

        public List<Course> EnrolledCourses { get; set; } = new List<Course>();

        public void AddEnrolledCourse(Course course)
        {
            EnrolledCourses.Add(course);
        }

    }
}
