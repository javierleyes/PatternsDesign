using System;

namespace Patronvisitante
{
    public interface IVisitor
    {
		double Visit(ClaseA elementA);
		double Visit(ClaseB elementB);
	}
}
