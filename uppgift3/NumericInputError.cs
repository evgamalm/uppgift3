using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift3
{
    class NumericInputError : UserError
    {
        public override string DoMessage()
        {
            return "You tried to use a numeric input!";
        }
    }
}
