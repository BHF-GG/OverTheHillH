using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverTheHillH
{
    public interface ISubject
    {
        void Register(IObserver observer);
        void UnRegister(IObserver observer);
        void NotifyObservers();
        int GetTimeOfDay();
    }
}
