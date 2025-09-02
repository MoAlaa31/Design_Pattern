using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    internal class Refree
    {
        public string Name { get; set; }
        public override string ToString()
            => $"Refree: {Name}";

        public void Look(Location newLocation)
            => Console.WriteLine($"{this.ToString()} is Looking");
    }
}
