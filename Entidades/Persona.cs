using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        public int Cedula { get; set; }
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }
        public char Sexo { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
