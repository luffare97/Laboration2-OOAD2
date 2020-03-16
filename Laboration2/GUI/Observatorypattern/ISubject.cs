using System.Collections.Generic;

namespace GUI.Observatorypattern
{
    public interface ISubject
    {
        List<IObserver1> ObserverCollection { get; set; }

        void Notify();
        void RegisterObserver(IObserver1 O);
        void UnregisterObserver(IObserver1 O);
    }
}