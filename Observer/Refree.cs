using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Refree : IObserver
    {
        public string Name { get; set; }
        public Location location { get; set; }

        public void Update(Location newlocation)
        {
            location = newlocation;
            Console.WriteLine($"{this.ToString()} is Looking at this location {location}");
        }

        public override string ToString()
            => $"Refree: {Name}";
    }
}
