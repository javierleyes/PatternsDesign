using System;

namespace PatronEstrategia
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Socio socio = new Socio();
            Alumno alumno = new Alumno();
            Profesor profesor = new Profesor();

            string TypeBook;

            TypeBook = new ContextFindLibro().BuscarLibroPorTipoUsuario(socio, "titulo del libro");
            Console.WriteLine("Estado del libro para Socios " + TypeBook);

            TypeBook = new ContextFindLibro().BuscarLibroPorTipoUsuario(alumno, "titulo del libro");
            Console.WriteLine("Estado del libro para Alumnos " + TypeBook);

            TypeBook = new ContextFindLibro().BuscarLibroPorTipoUsuario(profesor, "titulo del libro");
            Console.WriteLine("Estado del libro para Profesores " + TypeBook);
        }
    }
}
