using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_DP.With_DP
{
    interface IQuackBehaviour
    {
        void PerformQuack();
    }

    class NormalQuack : IQuackBehaviour
    {
        public void PerformQuack() 
        {
            Console.WriteLine("I am Quacking");
            Console.Beep();
        }
    }

    class Squeeking : IQuackBehaviour
    {
        public void PerformQuack()
        {
            Console.WriteLine("I am Squeeking");
            Console.Beep(37, 2000);
        }
    }
}
