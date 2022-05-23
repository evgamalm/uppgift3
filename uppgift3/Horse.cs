using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift3
{
    internal class Horse : Animal
    {
        bool HorseLikeApple = true;
        public bool HorseLike
        {
            get { return HorseLikeApple; }
            set { HorseLike = value; }
        }
        public override string DoSound()
        {
            return "iiehehehii";
        }
    }
}
