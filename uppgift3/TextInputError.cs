using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift3
{
    internal class TextInputError : UserError
    {
        public override string DoMessage()
        {
            return "numeric only  an error!";

        }

    }
}
