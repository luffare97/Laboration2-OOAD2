using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Observatorypattern
{
    public class Subject : ISubject
    {

        public List<IObserver> ObserverCollection { get; set; } = new List<IObserver>();

        public void RegisterObserver(IObserver O)
        {
            this.ObserverCollection.Add(O);
        }

        public void UnregisterObserver(IObserver O)
        {
            this.ObserverCollection.Remove(O);
        }

        public void Notify()
        {
            foreach (IObserver O in ObserverCollection)
            {
                O.Uppdate(this);
            }
        }
    }
}
