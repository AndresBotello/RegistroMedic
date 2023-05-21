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
        Archivo datosArchivo = new Archivo();

        public RegistroPaciente(string rutaArchivo) 
        {
            datosArchivo.DatosArchivo(rutaArchivo);
        }

        public void GuardarPaciente(Paciente paciente)
        {
            datosArchivo.GuardarPersona(paciente);
        }

        
    }
}
