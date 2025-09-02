using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_DP
{
    abstract class Beverage
    {
        public virtual decimal Cost { get; set; }
        public virtual string Description { get; set; }
        public override string ToString()
            => $"{Description} \nCost = {Cost} $";
    }

    class Espresso : Beverage
    {
        Beverage ?_beverage;
        public Espresso()
        {
            Description = "Espresso Coffee";
            Cost = 2.5M;
        }
        public Espresso(Beverage beverage)
        {
            Description = $"{beverage.Description} Douple Shot";
            Cost = beverage.Cost + 2.5M;
            _beverage = beverage;
        }
    }

    class HouseBlend : Beverage
    {
        Beverage _beverage;
        public HouseBlend(Beverage beverage)
        {
            Description = "House Blend";
            Cost = 3.5M;
            _beverage = beverage;
        }
    }

    class DarkRoast : Beverage
    {
        Beverage _beverage;
        public DarkRoast(Beverage beverage)
        {
            Description = "DarkRoast Coffee";
            Cost = 2.5M;
            _beverage = beverage;
        }
    }

    class Decafe : Beverage
    {
        Beverage _beverage;
        public Decafe(Beverage beverage)
        {
            Description = "Decafe Coffee";
            Cost = 4.5M;
            _beverage = beverage;
        }
    }
}
