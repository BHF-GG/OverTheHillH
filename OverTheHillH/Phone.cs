using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverTheHillH
{
    public class Phone : ISubject
    {
        private int TimeOfDay;
        private List<IObserver> _observers;

        public Phone()
        {
            TimeOfDay = 0;
            _observers = new List<IObserver>();
        }

        public void Register(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void UnRegister(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }

        public int GetTimeOfDay()
        {
            return TimeOfDay;
        }

        public void SetTimeOfDay(int i)
        {
            TimeOfDay = i;
            NotifyObservers();
        }
    }
}
