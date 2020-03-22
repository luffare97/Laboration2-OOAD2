using System.Collections.Generic;

namespace GUI.Observatorypattern
{
    public interface ISubject
    {
        List<IObserver> ObserverCollection { get; set; }

        void Notify();
        void RegisterObserver(IObserver O);
        void UnregisterObserver(IObserver O);
    }
}