using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfism
{
    class OutOfRangeError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to access a value that was outside of the given range. This fired an error!\n";
        }
    }
}
