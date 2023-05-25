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
        public DateTime FechaIngreso { get; set; }
        public string EPS { get; set; }
        public int NroIngreso { get; set; }
        public int Estrato { get; set; }
        public string MotivoIngreso { get; set; }
        public string ResultadoRevision { get; set; }
        public string TipoTratamiento { get; set; }
        public string FormaRealizacion { get; set; }
        public string MedicoCargo { get; set; }
        public string Diagnostico { get; set; }
        public string Observaciones { get; set; }

    }
}
