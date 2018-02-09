using System;

namespace PatronSingleton
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            Institucion instancia1 = Institucion.GetInstance();
            instancia1.Nombre = "Maria";
            Console.WriteLine("Instancia 1: " + instancia1.Nombre);

            Institucion instancia2 = Institucion.GetInstance();
            instancia2.Nombre = "Jose";
            Console.WriteLine("Instancia 2: " + instancia2.Nombre);

            Console.WriteLine("Nombre instancia1: " + instancia1.Nombre);
        }
    }
}
