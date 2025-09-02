using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Football
    {
		private Location location;
		private List<IObserver> subscribers;

		public Location ChangeLocation
		{
			get { return location; }
			set
			{
				if (!location.Equals(value))
				{
					location = value;
					if(subscribers is not null)
					{ Notify(location); }
				}
			}
		}

        public Football(Location newLocation)
        {
			location = newLocation;
			subscribers = new List<IObserver>();
            
        }

		public void Notify(Location newLocation)
		{
			foreach(var subscriber in subscribers)
			{
				subscriber.Update(newLocation);
			}
		}

		public void Subscribe(IObserver subscriber)
			=> subscribers.Add(subscriber);

		public void UnSubscribe(IObserver subscriber)
			=> subscribers.Remove(subscriber);
    }
}
