using System;
using System.Collections.Generic;
using System.Text;

namespace PatronFactoryMethod
{
    public class FactoryMethodTriangulo : IFactoryMethodTriangulo
    {
        public Triangulo CreateTriangulo(decimal ladoA, decimal ladoB, decimal ladoC)
        {
            if ((ladoA == ladoB) && (ladoA == ladoC))
            {
                Triangulo equilatero = new Equilatero(ladoA, ladoB, ladoC);

                return equilatero;
            }

            if ((ladoA == ladoB) || (ladoA == ladoC) || (ladoB == ladoC))
            {
                Triangulo isosceles = new Isosceles(ladoA, ladoB, ladoC);

                return isosceles;
            }

            Triangulo escaleno = new Escaleno(ladoA, ladoB, ladoC);

            return escaleno;
        }
    }
}
