using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;


namespace Logica
{
    public class RegistroPaciente 
    {
        private DatosArchivo datosArchivo;
        
        public RegistroPaciente(string rutaArchivo) 
        {
            datosArchivo = new DatosArchivo(rutaArchivo);
        }

        private void GuardarPaciente(Paciente paciente)
        {
            datosArchivo.GuardarPaciente(paciente);
        }

        
    }
}
