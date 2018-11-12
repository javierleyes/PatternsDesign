using System;
using System.Collections.Generic;
using System.Text;

namespace PatronFactoryMethod
{
    public class Escaleno : Triangulo
    {
        public Escaleno(decimal ladoA, decimal ladoB, decimal ladoC) : base(ladoA, ladoB, ladoC) { }

        public override string Nombre
        {
            get { return "Soy un triangulo Escaleno"; }
        }
    }
}
