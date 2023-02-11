using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1
{
    internal class Alumno
    {
        //Campos || Atributos
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Apellido { get; set; }

        public string TraerDatos() 
        {
            string datos = $"Datos: {Dni} {Nombre} {Apellido} {Email}";
            return datos;
        } 
    }
}
