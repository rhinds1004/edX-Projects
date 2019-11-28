using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOMod1SelfAssessment
{
    public class Teacher : IPerson, IEquatable<Teacher>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Teacher(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override bool Equals(object other)
        {
            if (other == null) return false;
            Teacher objAsCourse = other as Teacher;
            if (objAsCourse == null) return false;
            else return Equals(objAsCourse);
        }

        //Cast to object is important, if not there it would re-execute the operator == overload leading to a stackoverflow.
        public bool Equals(Teacher other)
        {
            if ((object)other == null) return false;
            if (this.FirstName.Equals(other.FirstName) && this.LastName.Equals(other.LastName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        //Cast to object is important, if not there it would re-execute the operator == overload leading to a stackoverflow.
        public static bool operator ==(Teacher teacher1, Teacher teacher2)
        {
            if ((object)teacher1 == null || (object)teacher2 == null) return false;
            if (teacher1.FirstName.Equals(teacher2.FirstName) && teacher1.LastName.Equals(teacher2.LastName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
        public static bool operator !=(Teacher teacher1, Teacher teacher2)
        {
            return !(teacher1 == teacher2);
        }
    }
}
