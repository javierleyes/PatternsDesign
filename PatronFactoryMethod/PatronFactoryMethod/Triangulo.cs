using System;
using System.Collections.Generic;
using System.Text;

namespace PatronFactoryMethod
{
    public abstract class Triangulo
    {
        public decimal LadoA { get; set; }
        public decimal LadoB { get; set; }
        public decimal LadoC { get; set; }

        public abstract string Nombre { get; }

        public Triangulo(decimal ladoA, decimal ladoB, decimal ladoC)
        {
            this.LadoA = LadoA;
            this.LadoB = LadoB;
            this.LadoC = LadoC;
        }

        public decimal getPerimetro()
        {
            return (this.LadoA + this.LadoB + this.LadoC);
        }
    }
}
