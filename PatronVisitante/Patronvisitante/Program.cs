using System;

namespace Patronvisitante
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            ClaseA elementA = new ClaseA() { Value = 1 };
            ClaseB elementB = new ClaseB() { Value = 1 };

            Visitor OperacionVisitante = new Visitor();

            double valueA = elementA.Accept(OperacionVisitante);
            double valueB = elementB.Accept(OperacionVisitante);

            Console.WriteLine(valueA);
            Console.WriteLine(valueB);
        }
    }
}
