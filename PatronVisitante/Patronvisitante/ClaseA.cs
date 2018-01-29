using System;

namespace Patronvisitante
{
    public class ClaseA : IVisitable
    {
        public int Value { get; set; }

        public double Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}