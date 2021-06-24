using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfism
{
    class DivideByZero : UserError
    {
        public override string UEMessage()
        {
            return "You tried to divide by zero. This fired an error!\n";
        }
    }
}
