using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    internal class Ball
    {
        public int Id { get; set; }

		private Location ballLocation;

		public Location BallLocation
		{
			get => ballLocation;
			set
			{
				if(ballLocation != value)
				{
					ballLocation = value;
					BallLocationChanged?.Invoke(value);
				}
			}
		}

		public event Action<Location> BallLocationChanged;
	}
}
