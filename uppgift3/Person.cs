using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift3
{
    internal class Person
    {
        private string _firstName;
        private string _lastName;
        private int _age;
        private double _height;
        private double _weight;

        public Person(string firstName, string lastName, int age, double height, double weight)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Height = height;
            Weight = weight;
        }


        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (value.Length < 2 && value.Length > 10)
                {
                    throw new ArgumentException("between 2 - 10");

                }
                else
                {
                    _firstName = value;
                }

            }

        }
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (value.Length < 3 && value.Length > 15)
                {
                    ;
                    throw new ArgumentException("Text 3 and not higher than 15. :");
                }
                else
                {
                    _lastName = value;
                }
            }
        }
        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 0)
                {
                    _age = value;
                }
                else
                {
                    
                    throw new ArgumentException("More then 0!");

                }
            }
        }
        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }
        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public override string ToString()
        {
            return $" First Name: {FirstName}\n Last Name: {LastName}\n Age: {Age} years old\n Height: {Height} cm\n Weight: {Weight} kg\n";
        }
    }
}
