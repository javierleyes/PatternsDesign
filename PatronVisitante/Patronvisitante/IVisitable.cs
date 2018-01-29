using System;

namespace Patronvisitante
{
    public interface IVisitable
    {
        double Accept(IVisitor visitor);
    }
}
