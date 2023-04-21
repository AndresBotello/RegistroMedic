using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente : Persona
    {
        public string Regimen { get; set; }
        public DateTime FechaAtencion { get; set; }
        public int Estrato { get; set; }
        public string Procedimiento { get; set; }
        public string FinalidadProcedimiento { get; set; }
        public string FormaRealizacion { get; set; }
        public string PersonalAtendio { get; set; }
        public string DiagnosticoPrincipal { get; set; }
        public string Observaciones { get; set; }
        public string MedicoCargo { get; set; }
    }
}
