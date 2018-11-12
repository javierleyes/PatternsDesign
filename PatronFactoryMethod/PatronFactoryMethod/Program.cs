using System;

namespace PatronFactoryMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            IFactoryMethodTriangulo factoryMethodTriangulo = new FactoryMethodTriangulo();

            Triangulo equilatero = factoryMethodTriangulo.CreateTriangulo(4, 4, 4);

            Console.WriteLine(equilatero.Nombre);

            Triangulo isosceles = factoryMethodTriangulo.CreateTriangulo(4, 4, 8);

            Console.WriteLine(isosceles.Nombre);

            Triangulo escaleno = factoryMethodTriangulo.CreateTriangulo(4, 8, 12);

            Console.WriteLine(escaleno.Nombre);
        }
    }
}
