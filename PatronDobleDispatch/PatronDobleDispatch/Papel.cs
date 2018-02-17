using System;
namespace PatronDobleDispatch
{
    public class Papel : IJugable
    {
        public string PelearContra(IJugable elemento)
        {
            return elemento.PelearContra(this);
        }

        public string PelearContra(Tijera tijera)
        {
            return "Perdi..";
        }

        public string PelearContra(Piedra piedra)
        {
            return "Gane..";
        }

        public string PelearContra(Papel papel)
        {
            return "Empate..";
        }
    }
}
