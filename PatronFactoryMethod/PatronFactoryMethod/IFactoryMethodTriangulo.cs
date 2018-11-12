using System;
using System.Collections.Generic;
using System.Text;

namespace PatronFactoryMethod
{
    public interface IFactoryMethodTriangulo
    {
        Triangulo CreateTriangulo(decimal ladoA, decimal ladoB, decimal ladoC);
    }
}
