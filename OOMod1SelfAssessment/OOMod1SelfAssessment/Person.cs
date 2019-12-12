using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOMod1SelfAssessment
{
    public abstract class Person : IEquatable<Person>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public override bool Equals(object other)
        {
            if (other == null) return false;
            Person objAsCourse = other as Person;
            if (objAsCourse == null) return false;
            else return Equals(objAsCourse);
        }

        public bool Equals(Person other)
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

        //Cast to object is important, if not there it would re-execute the operator == overload leading to a stackoverflow.
        public static bool operator ==(Person person1, Person person2)
        {
            if ((object)person1 == null || (object)person2 == null) return false;
            if (person1.FirstName.Equals(person2.FirstName) && person1.LastName.Equals(person2.LastName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static bool operator !=(Person person1, Person person2)
        {
            return !(person1 == person2);
        }


        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }


}
