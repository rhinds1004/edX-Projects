using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOMod1SelfAssessment
{
    public class Degree
    {
        public List<Course> CoursesList { get; set; } = new List<Course>();
        public string DegreeName { get; set; }
      

        public Degree(string degreeName)
        {
            this.DegreeName = degreeName;
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
