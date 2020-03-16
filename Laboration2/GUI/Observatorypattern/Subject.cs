using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Observatorypattern
{
    public class Subject : ISubject
    {

        public List<IObserver1> ObserverCollection { get; set; } = new List<IObserver1>();

        public void RegisterObserver(IObserver1 O)
        {
            ObserverCollection.Add(O);
        }

        public void UnregisterObserver(IObserver1 O)
        {
            ObserverCollection.Remove(O);
        }

        public void Notify()
        {
            foreach (IObserver1 O in ObserverCollection)
            {
                O.Uppdate(this);
            }
        }
    }
}
