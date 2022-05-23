using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift3
{
    internal class Bird : Animal
    {
        
        

            bool iCanFly = true;
            bool fly

            {
                get { return iCanFly; }
                set { iCanFly = value; }
            }
            public override string DoSound()
            {
                return "ka ka";
            }
        
    }
}
