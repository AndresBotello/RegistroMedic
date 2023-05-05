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
        private readonly string rutaArchivo = "Registro medico.txt";

        public void AgregarPaciente(Paciente paciente) 
        {
            using (StreamWriter writer = new StreamWriter(rutaArchivo, true)) 
            {
                writer.WriteLine($"{paciente.Cedula},{paciente.Nombre},{paciente.Telefono},{paciente.Edad},{paciente.Direccion},{paciente.Sexo}");
            }
        }

    }
}
