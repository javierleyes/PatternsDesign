using System;
namespace PatronObservable
{
    public class ObserverAlerta : IObserver
    {
        // Niveles minimos y maximos
        private static readonly int MIN_ACEITE = 12;
        private static readonly int MAX_ACEITE = 45;

        private static readonly int MIN_AGUA = 300;
        private static readonly int MAX_AGUA = 550;

        public int nivelAceite { get; set; }
        public int nivelAgua { get; set; }

        public void Update(object o)
        {
            // Comprobamos el tipo del objeto recibido como parametro
            int[] arrayInt = null;
            if (o.GetType().Equals(typeof(int[])))
                arrayInt = (int[])o;

            // Si es del tipo esperado (int[]) y del tamano esperado (2), actualizamos los
            // atributos
            if ((arrayInt != null) && (arrayInt.Length == 2))
            {
                nivelAceite = arrayInt[0];
                nivelAgua = arrayInt[1];

                // Comprobamos que los valores no exceden los limites
                ComprobarAceite();
                ComprobarAgua();
            }

        }

        // Metodo que comprueba los niveles de aceite
        private void ComprobarAceite()
        {
            if (nivelAceite < MIN_ACEITE)
            {
                EnviarAlerta();
                Console.WriteLine(String.Format("NIVEL DE ACEITE DEMASIADO BAJO: {0}/{1}", nivelAceite, MIN_ACEITE));
            }
            if (nivelAceite > MAX_ACEITE)
            {
                EnviarAlerta();
                Console.WriteLine(String.Format("NIVEL DE ACEITE DEMASIADO ALTO: {0}/{1}", nivelAceite, MAX_ACEITE));
            }
        }

        // Metodo que comprueba los niveles de agua
        private void ComprobarAgua()
        {
            if (nivelAgua < MIN_AGUA)
            {
                EnviarAlerta();
                Console.WriteLine(String.Format("NIVEL DE AGUA DEMASIADO BAJO: {0}/{1}", nivelAgua, MIN_AGUA));
            }
            if (nivelAgua > MAX_AGUA)
            {
                EnviarAlerta();
                Console.WriteLine(String.Format("NIVEL DE AGUA DEMASIADO ALTO: {0}/{1}", nivelAgua, MAX_AGUA));
            }
        }

        // Metodo que envie la alerta
        private void EnviarAlerta()
        {
            // Este metodo podria enviar una alerta a la centralita del vehiculo que, por ejemplo,
            // forzaria a su detencion
            Console.WriteLine("ALERTA!!");
        }
    }
}
