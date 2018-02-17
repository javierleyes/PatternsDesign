using System;
using System.Collections.Generic;

namespace PatronObservable
{
    public class MedidorSensores : IObservable
    {
        private int nivelAceite;
        private int nivelAgua;

        // Observers list
        private IList<IObserver> Observers;

        public int NivelAceite
        {
            get { return this.nivelAceite; }

            set
            {
                if (this.nivelAceite != value)
                {
                    this.nivelAceite = value;
                    NotifyObservers();
                }
            }
        }

        public int NivelAgua
        {
            get { return this.nivelAgua; }

            set
            {
                if (this.nivelAgua != value)
                {
                    this.nivelAgua = value;
                    NotifyObservers();
                }
            }
        }

        public MedidorSensores(int nivelAceite, int nivelAgua)
        {
            this.Observers = new List<IObserver>();
            this.nivelAceite = nivelAceite;
            this.nivelAgua = nivelAgua;
        }

        public void Attach(IObserver observer)
        {
            if (!this.Observers.Contains(observer))
            {
                this.Observers.Add(observer);
            }
        }

        public void Dettach(IObserver observer)
        {
			if (this.Observers.Contains(observer))
			{
				this.Observers.Remove(observer);
			}
        }

        // Se puede adaptar este metodo para que las notificaciones sean tipo PUSH o PULL
        // tambien para que exista un umbral en la variacion del estado para realizar la notificacion
        public void NotifyObservers()
        {
            int[] valores = { this.nivelAceite, this.nivelAgua };

            foreach (IObserver observer in this.Observers)
            {
                observer.Update(valores);
            }
        }
    }
}
