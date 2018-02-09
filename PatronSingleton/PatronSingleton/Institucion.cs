using System;
namespace PatronSingleton
{
    public class Institucion
    {
        private Institucion() { }

        //Thread Safe
        private static Institucion instance = new Institucion();

        public string Nombre { get; set; }

        public static Institucion GetInstance()
        {
            return instance;
        }
    }
}
