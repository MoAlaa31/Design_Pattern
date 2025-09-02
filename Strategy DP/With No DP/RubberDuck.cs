using Strategy_DP.With_DP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_DP.With_No_DP
{
    internal class RubberDuck : Duck
    {
        public RubberDuck() : base(new NoFLy(), new Squeeking())
        {
            
        }

        public override void Display()
        {
            Console.WriteLine("I am Rubber Duck");
        }
    }
}
