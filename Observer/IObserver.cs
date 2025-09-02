using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal interface IObserver
    {
        public string Name { get; set; }
        public Location location { get; set; }

        void Update(Location location);
    }
}
