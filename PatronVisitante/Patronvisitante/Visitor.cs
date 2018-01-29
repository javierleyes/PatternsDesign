using System;
namespace Patronvisitante
{
    public class Visitor : IVisitor
    {
        public double Visit(ClaseA elementA)
        {
            elementA.Value = 10;

            return elementA.Value * 1;
        }

        public double Visit(ClaseB elementB)
        {
            elementB.Value = 20;

            return elementB.Value * 1;
        }
    }
}
