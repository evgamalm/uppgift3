using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift3
{
    internal class PersonHandler
    {
        public void SetFirstName(Person pers, string firstName)
        {
            pers.FirstName = firstName;

        }
        public void SetLastName(Person pers, string lastName)
        {
            pers.LastName = lastName;
        }
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }
        public void SetHeight(Person pers, double height)
        {
            pers.Height = height;
        }
        public void SetWeight(Person pers, double weight)
        {
            pers.Weight = weight;
        }

        public Person CreatePerson(string firstName, string lastName, int age, double height, double weight)
        {
            Person person1 = new Person("patrick", "malmkvist", 34, 175.5, 70);
            person1.Age = age;
            person1.FirstName = firstName;
            person1.LastName = lastName;
            person1.Weight = weight;
            return person1;
        }
    }
}
