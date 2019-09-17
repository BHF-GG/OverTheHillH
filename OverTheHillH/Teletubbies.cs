using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverTheHillH
{

    public class Teletubbies : IObserver
    {
        private ISubject _subject;

        public Teletubbies(ISubject subject)
        {
            _subject = subject;
            _subject.Register(this);
        }
        public void Update()
        {
            int timeOfDay = _subject.GetTimeOfDay();

            switch (timeOfDay)
            {
                case 1:
                    WakeUp();
                    break;
                case 2:
                    HaveDinner();
                    break;
                case 3:
                    WatchTelevision();
                    break;
                case 4:
                    SayByeBye();
                    break;
            }
        }

        private void WakeUp()
        {
            Console.WriteLine("WakeUp");
        }

        private void HaveDinner()
        {
            Console.WriteLine("Have Dinner");
        }

        private void WatchTelevision()
        {
            Console.WriteLine("TV Time!!");
        }

        private void SayByeBye()
        {
            Console.WriteLine("ByeBye");
        }
    }
}
