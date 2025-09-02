using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_DP
{
    abstract class Decorator : Beverage
    {
        protected Beverage _beverage;

        protected Decorator(Beverage beverage)
        {
            _beverage = beverage;
        }
    }
    class Milk : Decorator
    {
        public Milk(Beverage beverage): base(beverage)
        {
        }

        public override string Description => $"{_beverage.Description}, With Milk";
        public override decimal Cost => _beverage.Cost + 1.5M;
    }

    class Mocha : Decorator
    {
        public Mocha(Beverage beverage) : base(beverage)
        {
        }

        public override string Description => $"{_beverage.Description}, With Mocha";
        public override decimal Cost => _beverage.Cost + 2.3M;
    }

    class Caramel : Decorator
    {
        public Caramel(Beverage beverage) : base(beverage)
        {
        }

        public override string Description => $"{_beverage.Description}, With Caramel";
        public override decimal Cost => _beverage.Cost + 1.3M;
    }
}
