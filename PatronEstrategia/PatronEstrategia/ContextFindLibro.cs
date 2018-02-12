using System;
namespace PatronEstrategia
{
    public class ContextFindLibro
    {
        IBuscarLibroStrategy BuscarLibroStrategy { get; set; }

        public string BuscarLibroPorTipoUsuario(Persona persona, string titulo)
        {
            /*if (persona.GetType() == typeof(Alumno))
                BuscarLibroStrategy = new DesusoStrategy();
            
            else if (persona.GetType() == typeof(Profesor))
                BuscarLibroStrategy = new UsadoStrategy();
            else
                BuscarLibroStrategy = new NuevoStrategy();*/

            switch (persona.GetType().Name)
            {
                case "Alumno":
                    BuscarLibroStrategy = new DesusoStrategy();
                    break;
				case "Profesor":
					BuscarLibroStrategy = new UsadoStrategy();
					break;
				case "Socio":
					BuscarLibroStrategy = new NuevoStrategy();
					break;
            }

            return BuscarLibroStrategy.FindLibro(titulo);
        }
    }
}
