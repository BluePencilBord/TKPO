using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tkpo_lab6
{
    public abstract class Observable
    {
        protected List<IObserver> _observers = new();

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        protected void NotifyUpdate()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }
    }
}
