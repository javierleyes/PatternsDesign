using System;
namespace PatronObservable
{
    public class ObserverDisplay : IObserver
    {
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

                // Mostramos por pantalla los valores actuales
                MostrarValores();
            }
        }

        // Metodo que muestra los valores en el display
        private void MostrarValores()
        {
            Console.WriteLine("Nivel de Aceite: " + nivelAceite);
            Console.WriteLine("Nivel de Agua: " + nivelAgua + "\n");
        }
    }
}
