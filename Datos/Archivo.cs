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
                $"{paciente.FechaNacimiento},{paciente.FechaIngreso},{paciente.EPS},{paciente.NroIngreso},{paciente.MotivoIngreso},{paciente.ResultadoRevision}," +
                $"{paciente.TipoTratamiento},{paciente.FormaRealizacion},{paciente.Diagnostico},{paciente.MedicoCargo}," +
                $"{paciente.Observaciones},";

            // Escribe los datos en el archivo de texto
            using (StreamWriter sw = new StreamWriter(rutaArchivo, true))
            {
                sw.WriteLine(datos);
            }
        }

        public void ActualizarPersona(Paciente paciente)
        {
            string datosExistentes = File.ReadAllText(rutaArchivo);

            string[] campos = datosExistentes.Split(',');
            campos[0] = paciente.Cedula.ToString();
            campos[1] = paciente.Nombre;
            campos[2] = paciente.Telefono.ToString();
            campos[3] = paciente.Edad.ToString();
            campos[4] = paciente.Direccion;
            campos[5] = paciente.Sexo.ToString();
            campos[6] = paciente.Estrato.ToString();
            campos[7] = paciente.Regimen;
            campos[8] = paciente.FechaNacimiento.ToString();
            campos[9] = paciente.FechaIngreso.ToString();
            campos[10] = paciente.EPS;
            campos[11] = paciente.NroIngreso.ToString();
            campos[12] = paciente.MotivoIngreso;
            campos[13] = paciente.ResultadoRevision;
            campos[14] = paciente.TipoTratamiento;
            campos[15] = paciente.FormaRealizacion;
            campos[16] = paciente.Diagnostico;
            campos[17] = paciente.MedicoCargo;
            campos[18] = paciente.Observaciones;

            string datosActualizados = string.Join(",", campos);

            File.WriteAllText(rutaArchivo, datosActualizados);
        }
        public Paciente BuscarPorCedula(String cedula)
        {
            string[] lineas = File.ReadAllLines("Registro medico.txt");

            string lineaEncontrada = lineas.FirstOrDefault(linea => linea.StartsWith(cedula));

            if (lineaEncontrada != null)
            {
                // Dividir la línea en campos
                string[] campos = lineaEncontrada.Split(',');

                // Crear un objeto Datos con los valores correspondientes
                Paciente datos = new Paciente
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

                return datos;
            }
            else
            {
                return null; // No se encontró la cédula
            }
        }
    }   
}
