using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfism
{
    class NullInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a null input in a field that requires an input. This fired an error!\n";
        }
    }
}
