using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOMod1SelfAssessment
{
    public class Course : ICourse, IEquatable<Course>
    {
        private List<Student> studentsInCourse = new List<Student>();
        private List<Teacher> teachersOfCourse = new List<Teacher>();

        public Course(string courseName)
        {
            CourseName = courseName;
        }

        public string CourseName { get; set; }
      //  public List<Student> StudentsInCourse { get => studentsInCourse;}

        
        public void AddStudent(Student newStudent)
        {
            studentsInCourse.Add(newStudent);
        }

        public override bool Equals(object other)
        {
            if (other == null) return false;
            Course objAsCourse = other as Course;
            if (objAsCourse == null) return false;
            else return Equals(objAsCourse);
        }

        public bool Equals(Course other)
        {
            if (other == null) return false;
            return (this.CourseName.Equals(other.CourseName));
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public int StudentCount()
        {
            return studentsInCourse.Count();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public bool AddTeacher(Teacher newTeacher)
        {
            teachersOfCourse.Add(newTeacher);
            return teachersOfCourse.Contains(newTeacher);
        }

        public bool IsCourseTeacher(string firstName, string lastName)
        {
            foreach(Teacher teacher in teachersOfCourse )
            {
               if(teacher.FirstName == firstName && teacher.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
