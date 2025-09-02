using Strategy_DP.With_DP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_DP.With_No_DP
{
    internal abstract class Duck
    {
        public IFlyBehaviour FlyBehaviour {  get; set; }
        public IQuackBehaviour QuackBehaviour { get; }

        public Duck(IFlyBehaviour flyBehaviour, IQuackBehaviour quackBehaviour)
        {
            FlyBehaviour = flyBehaviour;
            QuackBehaviour = quackBehaviour;
        }
        public abstract void Display();

        public void Swim() 
            => Console.WriteLine("I am Swimming");

        public void Quack()
        {
            QuackBehaviour.PerformQuack();
        }

        public void Fly()
        {
            FlyBehaviour.PerformFly();
        }
        
    }
}
