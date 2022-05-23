using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift3
{
    internal class Dog : Animal
    {
        bool Doglike = true;
        public bool Doggi
        {
            get { return Doglike; }
            set { Doggi = value; }
        }
        public override string DoSound()
        {
            return "waouf";
        }
    }
}

