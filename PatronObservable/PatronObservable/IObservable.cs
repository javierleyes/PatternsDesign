using System;
namespace PatronObservable
{
    public interface IObservable
    {
		void Attach(IObserver observer);
		void Dettach(IObserver observer);
		void NotifyObservers();
    }
}
