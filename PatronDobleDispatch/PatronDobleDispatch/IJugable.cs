using System;
namespace PatronDobleDispatch
{
	public interface IJugable
	{
		string PelearContra(IJugable elemento);

		string PelearContra(Tijera tijera);

		string PelearContra(Piedra piedra);

		string PelearContra(Papel papel);
	}
}
