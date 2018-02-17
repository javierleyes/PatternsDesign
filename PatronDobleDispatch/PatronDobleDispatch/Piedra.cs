using System;
namespace PatronDobleDispatch
{
    public class Piedra : IJugable
    {
        public string PelearContra(IJugable elemento)
        {
            return elemento.PelearContra(this);
        }

        public string PelearContra(Tijera tijera)
        {
            return "Gane..";
        }

        public string PelearContra(Piedra piedra)
        {
            return "Empate..";
        }

        public string PelearContra(Papel papel)
        {
            return "Perdi..";
        }
    }
}
