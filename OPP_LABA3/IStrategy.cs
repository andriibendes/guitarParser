using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_LABA3
{
    interface IStrategy
    {
        List<Guitar> Algorithm(Guitar guitar, string path);
    }
}
