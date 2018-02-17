using System;

namespace PatronDobleDispatch
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            Piedra piedra = new Piedra();
            Papel papel = new Papel();
            Tijera tijera = new Tijera();

            Console.WriteLine(String.Format("{0} contra {1}, resultado: {2}", piedra.GetType().Name, piedra.GetType().Name, piedra.PelearContra(piedra)));
            Console.WriteLine(String.Format("{0} contra {1}, resultado: {2}", piedra.GetType().Name, papel.GetType().Name, piedra.PelearContra(papel)));
            Console.WriteLine(String.Format("{0} contra {1}, resultado: {2}", piedra.GetType().Name, tijera.GetType().Name, piedra.PelearContra(tijera)));

            Console.WriteLine();

            Console.WriteLine(String.Format("{0} contra {1}, resultado: {2}", papel.GetType().Name, piedra.GetType().Name, papel.PelearContra(piedra)));
            Console.WriteLine(String.Format("{0} contra {1}, resultado: {2}", papel.GetType().Name, papel.GetType().Name, papel.PelearContra(papel)));
            Console.WriteLine(String.Format("{0} contra {1}, resultado: {2}", papel.GetType().Name, tijera.GetType().Name, papel.PelearContra(tijera)));

            Console.WriteLine();

            Console.WriteLine(String.Format("{0} contra {1}, resultado: {2}", tijera.GetType().Name, piedra.GetType().Name, tijera.PelearContra(piedra)));
            Console.WriteLine(String.Format("{0} contra {1}, resultado: {2}", tijera.GetType().Name, papel.GetType().Name, tijera.PelearContra(papel)));
            Console.WriteLine(String.Format("{0} contra {1}, resultado: {2}", tijera.GetType().Name, tijera.GetType().Name, tijera.PelearContra(tijera)));
        }
    }
}
