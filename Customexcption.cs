using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Customexcption: Exception
    {
        public override string Message => $"{DateTime.Now.ToString()}: Internal Exception in custom";
    }
}

