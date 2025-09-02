using Strategy_DP.With_DP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_DP.With_No_DP
{
    internal class Mallard_Duck : Duck
    {
        public Mallard_Duck() : base(new NormalSpeedFly(), new NormalQuack())
        {
        }

        public override void Display()
            => Console.WriteLine("I am Mallard Duck");
    }
}
