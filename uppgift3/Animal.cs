using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift3
{
    abstract class Animal
    {
        

        protected string name;
        protected int age;
        protected double weight;

        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }
        public double Weight { get { return weight; } set { weight = value; } }

        
        public abstract string DoSound();

        public Animal()
        {

        }

    }
}
