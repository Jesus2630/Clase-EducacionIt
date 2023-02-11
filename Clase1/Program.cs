
namespace Clase1
{
    internal class Program 
    {
        static void Main(string[] args)
        {

            //Primer Instancia
            Alumno miAlumno = new Alumno();

            miAlumno.Nombre = "Jesus";
            miAlumno.Apellido = "Farias";
            miAlumno.Dni = 8472932;
            miAlumno.Email = "jesus.fg2630@gmail.com";

            //Segunda Instancia
            Alumno miAlumno2 = new Alumno();

            miAlumno2.Nombre = "Lucas";
            miAlumno2.Apellido = "Perez";
            miAlumno2.Dni = 12354123;
            miAlumno2.Email = "Perelu@gmail.com";

            Console.WriteLine(miAlumno.TraerDatos());
            Console.WriteLine(miAlumno2.TraerDatos());
            

        }

    }
}
