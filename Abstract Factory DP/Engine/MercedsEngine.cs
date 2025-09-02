using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_DP.Engine
{
    internal class MercedsEngine : IEngine
    {
        public int HorsePower => 2000;

        public int MaxSpeed => 200;
    }
}
