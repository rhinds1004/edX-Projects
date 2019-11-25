using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOMod1SelfAssessment
{
    public class Student : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public static int StudentCount { get; set; } = 0;
        
        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            StudentCount++;
        }
    }
}
