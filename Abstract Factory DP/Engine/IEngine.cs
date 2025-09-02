using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_DP.Engine
{
    internal interface IEngine
    {
        public int HorsePower { get; }
        public int MaxSpeed { get; }

    }
}
