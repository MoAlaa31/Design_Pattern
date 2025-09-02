using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_DP.Engine
{
    internal class PMWEngine : IEngine
    {
        public int HorsePower => 2200;

        public int MaxSpeed => 180;
    }
}
