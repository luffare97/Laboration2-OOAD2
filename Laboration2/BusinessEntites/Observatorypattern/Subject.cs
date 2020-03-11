using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites.Observatorypattern
{
    public class Subject
    {

        public List<Observer> ObserverCollection { get; set; }

        public void RegisterObserver(Observer O)
        {
            ObserverCollection.Add(O);
        }

        public void UnregisterObserver(Observer O)
        {
            ObserverCollection.Remove(O);
        }

        public void Notify()
        {
            foreach (Observer O in ObserverCollection)
            {
                O.Uppdate();
            }
        }
    }
}
