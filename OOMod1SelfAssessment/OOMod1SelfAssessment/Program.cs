using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOMod1SelfAssessment
{
    class Program
    {
        static void Main(string[] args)
        {

            UProgram IntTech = new UProgram("Information Technoplogy");
           // IntTech.ProgramName = "Information Technoplogy";

            Student student1 = new Student("Autumn", "Hinds");
            Student student2 = new Student ("Jackson", "Hinds");
            Student student3 = new Student("Robert", "Hinds");

            Course proCourse = new Course("Programming with C#");

            Teacher teacher = new Teacher("No", "Name");

            proCourse.AddTeacher(teacher);
            proCourse.AddStudent(student1);
            proCourse.AddStudent(student2);
            proCourse.AddStudent(student3);


            Course advProCourse = new Course("Advanced Programming with C#");
            advProCourse.AddTeacher(teacher);
            advProCourse.AddStudent(student1);
            advProCourse.AddStudent(student2);


            Degree bachOfSci = new Degree("Bachelor of Science");

            bachOfSci.AddCourse(proCourse);
            bachOfSci.AddCourse(advProCourse);

            IntTech.Degree = bachOfSci;

            Console.WriteLine($"Program: {IntTech.ProgramName}  Degree: {IntTech.Degree.DegreeName}");
            foreach(Course course in IntTech.Degree.CoursesList)
            {
                Console.WriteLine($"Course: {course.CourseName}  student count: {course.StudentCount()}");
            }
            
                       



        }
    }
}
