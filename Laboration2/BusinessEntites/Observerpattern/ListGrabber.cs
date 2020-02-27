using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntites
{
    public class ListGrabber : ISubject
    {
        public ICollection<IObserver> observers { get; set; }
        public ListGrabber()
        {
            observers = new List<IObserver>();
        }
        
        public void notifyObserver()
        {

            foreach (IObserver observer in observers)
            {
                observer.uppdate();
            }
            throw new NotImplementedException();
        }

        public void register(IObserver newObserver)
        {
            observers.Add(newObserver);

            throw new NotImplementedException();
        }

        public void unregister(IObserver deleteObserver)
        {
            //int observerIndex = observers[deleteObserver];

            observers.Remove(deleteObserver);

            throw new NotImplementedException();
        }

        public void setList()
        {
            //this.List.Titel = newTitel;
            //this.List.Information = newInfo;


        }
    }
}
