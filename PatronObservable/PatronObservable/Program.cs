using System;

namespace PatronObservable
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            MedidorSensores sensores = new MedidorSensores(20, 380);

            IObserver display = new ObserverDisplay();
            IObserver alerta = new ObserverAlerta();

            sensores.Attach(display);
            sensores.Attach(alerta);

            sensores.NivelAceite += 10;
            sensores.NivelAceite += 10;
            sensores.NivelAgua += 100;
            sensores.NivelAceite += 10;
            sensores.NivelAgua += 100;
            sensores.NivelAgua += 100;

            sensores.NivelAceite += 10;
            sensores.NivelAceite += 10;
            sensores.NivelAgua += 100;

            sensores.Dettach(alerta);

            sensores.NivelAceite += 10;
            sensores.NivelAgua += 100;
            sensores.NivelAgua += 100;
        }
    }
}
