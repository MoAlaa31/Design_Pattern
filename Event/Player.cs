using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    internal class Player
    {
        public string Name {  get; set; }
        public string Team { get; set; }
        public override string ToString()
            => $"Player: {this.Name}, Team: {this.Team}";

        public void Run(Location newLocation)
            => Console.WriteLine($"{this.ToString()} is Running.....Towards {newLocation}");
    }
}
