using System;

namespace Patronvisitante
{
    public class ClaseB : IVisitable
    {
        public int Value { get; set; }

        public double Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}