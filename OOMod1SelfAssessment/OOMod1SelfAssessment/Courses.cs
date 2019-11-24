using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOMod1SelfAssessment
{
    public class Courses
    {
        public List<Course> CoursesList { get; set; } = new List<Course>();
        public string CoursesName { get; set; }
      

        public Courses(string CoursesName)
        {
            this.CoursesName = CoursesName;
        }

       public void AddCourse(Course course)
        {
            CoursesList.Add(course);
                            
        }

       public int CourseCount()
        {
            return CoursesList.Count();
        }

        public bool CheckForCourseByName(string courseName)
        {
           return CoursesList.Exists(x => x.CourseName.Contains(courseName));
        }
    }
}
