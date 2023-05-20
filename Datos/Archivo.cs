using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class Archivo
    {
        string rutaArchivo /*= "Registro medico.txt"*/;

        public void DatosArchivo(string rutaArchivo)
        {
            this.rutaArchivo = rutaArchivo;
        }

        public void GuardarPersona(Paciente paciente)
        {
            // Crea una cadena con el formato deseado para guardar los datos en el archivo
            string datos = $"{paciente.Cedula},{paciente.Nombre},{paciente.Telefono},{paciente.Edad}" +
                $"{paciente.Direccion},{paciente.Sexo},{paciente.Estrato},{paciente.Regimen}," +
                $"{paciente.FechaNacimiento},{paciente.FechaIngreso},{paciente.MotivoIngreso},{paciente.ResultadoRevision}," +
                $"{paciente.TipoTratamiento},{paciente.FormaRealizacion},{paciente.Diagnostico},{paciente.MedicoCargo}," +
                $"{paciente.Observaciones},";

            // Escribe los datos en el archivo de texto
            using (StreamWriter sw = new StreamWriter(rutaArchivo, true))
            {
                sw.WriteLine(datos);
            }
        }

    }   
}
