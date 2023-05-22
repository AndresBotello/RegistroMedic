using System;
using System.Collections.Generic;
using System.IO;
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
        //private RegistroPaciente datosPaciente;

        public RegistroPaciente(string rutaArchivo)
        {
            datosArchivo.DatosArchivo(rutaArchivo);
        }

        public RegistroPaciente()
        {
        }

        public void GuardarPaciente(Paciente paciente)
        {
            datosArchivo.GuardarPersona(paciente);
        }

        public void ActualizarPaciente(int Cedula, string Nombre, int Telefono, int Edad, string Direccion,
            char Sexo, int Estrato, string Regimen, DateTime FechaNaciemiento, DateTime FechaIngreso, string MotivoIngreso,
            string ResultadoRevision, string TipoTratamiento, string FormaRealizacion, string Diagnostico, string MedicoCargo,
            string Observaciones)
        {
            string datosExistentes = File.ReadAllText("Registro Medico.txt");

            string[] campos = datosExistentes.Split(';');

            campos[0] = Cedula.ToString();
            campos[1] = Nombre;
            campos[2] = Telefono.ToString();
            campos[3] = Edad.ToString();
            campos[4] = Direccion;
            campos[5] = Sexo.ToString();
            campos[6] = Estrato.ToString();
            campos[7] = Regimen;
            campos[8] = FechaNaciemiento.ToString();
            campos[9] = FechaIngreso.ToString();
            campos[10] = MotivoIngreso;
            campos[11] = ResultadoRevision;
            campos[12] = TipoTratamiento;
            campos[13] = FormaRealizacion;
            campos[14] = Diagnostico;
            campos[15] = MedicoCargo;
            campos[16] = Observaciones;

            Paciente datosActualizados = new Paciente
            {
                Cedula = Convert.ToInt32(campos[0]),
                Nombre = campos[1],
                Telefono = Convert.ToInt32(campos[2]),
                Edad = Convert.ToInt32(campos[3]),
                Direccion = campos[4],
                Sexo = Convert.ToChar(campos[5]),
                Estrato = Convert.ToChar(campos[6]),
                Regimen = campos[7],
                FechaNacimiento = Convert.ToDateTime(campos[8]),
                FechaIngreso = Convert.ToDateTime(campos[9]),
                MotivoIngreso = campos[10],
                ResultadoRevision = campos[11],
                TipoTratamiento = campos[12],
                FormaRealizacion = campos[13],
                Diagnostico = campos[14],
                MedicoCargo = campos[15],
                Observaciones = campos[16],
            };

            datosArchivo.ActualizarPersona(datosActualizados);
        }

        public Paciente BuscarPorCedula(string cedula)
        {
            return datosArchivo.BuscarPorCedula(cedula);
        }
    }
}
