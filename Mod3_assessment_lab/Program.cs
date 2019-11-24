using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_assessment_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
               // GetStudentInformation();
              //  GetTeacherInformation();
                validateStudentBirthday("10-4-1981");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        static void GetStudentInformation()
        {
            Console.WriteLine("Enter student's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter studen's last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine($"Enter {firstName} {lastName}'s birthday: ");
            string studentBirthday = Console.ReadLine();
            //   DateTime birthday = DateTime.Parse(studentBirthday);
            PrintStudentDetails(firstName, lastName, studentBirthday);
        }

        static void PrintStudentDetails(string first, string last, string birthday)
        {
            Console.WriteLine("{0} {1} was born on: {2}", first, last, birthday);
        }


        static void GetTeacherInformation()
        {
            Console.WriteLine("Enter teacher's name: ");
            string teacherName = Console.ReadLine();
            Console.WriteLine("Enter course name: ");
            string courseName = Console.ReadLine();
            Console.WriteLine($"Enter program: ");
            string programName = Console.ReadLine();
            Console.WriteLine($"Enter degree:  ");
            string degreeName = Console.ReadLine();
            //   DateTime birthday = DateTime.Parse(studentBirthday);
            PrintTeacherDetails(teacherName, courseName, programName, degreeName);
        }

        static void PrintTeacherDetails(string teacher, string course, string program, string degree)
        {
            Console.WriteLine("{0} {1} {2} {3}", teacher, course, program, degree);
        }

        static void validateStudentBirthday(string birthday)
        {
            throw new NotImplementedException();
        }
    }


}
