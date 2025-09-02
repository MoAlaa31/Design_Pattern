using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Player : IObserver
    {
        public string Name { get; set; }
        public string Team { get; set; }
        public Location location { get; set; }

        public void Update(Location newLocation)
        {
            location = newLocation;
            Console.WriteLine($"{this.ToString()} is Running towards this Location {location}");
        }

        public override string ToString()
            => $"Player: {Name}, at Team: {Team}";
    }
}
