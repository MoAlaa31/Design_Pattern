using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_DP
{
    interface IFlyBehaviour
    {
        void PerformFly();
    }
    class NoFLy : IFlyBehaviour
    {
        public void PerformFly()
            => Console.WriteLine("No Wings to fly");
    }
    class NormalSpeedFly : IFlyBehaviour
    {
        public void PerformFly()
            => Console.WriteLine("I am Flying With Normal Speed");
    }
}
