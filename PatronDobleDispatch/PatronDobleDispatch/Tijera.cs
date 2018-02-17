using System;
namespace PatronDobleDispatch
{
    public class Tijera : IJugable
    {
        public string PelearContra(IJugable elemento)
        {
            return elemento.PelearContra(this);
        }

        public string PelearContra(Tijera tijera)
        {
            return "Empate..";
        }

        public string PelearContra(Piedra piedra)
        {
            return "Perdi..";
        }

        public string PelearContra(Papel papel)
        {
            return "Gane..";
        }
    }
}
