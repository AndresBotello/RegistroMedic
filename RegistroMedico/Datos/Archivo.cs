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
            string datos = $"{paciente.Cedula}-{paciente.Nombre}-{paciente.Telefono}-{paciente.Edad}-" +
                $"{paciente.Direccion}-{paciente.Sexo}-{paciente.Estrato}-{paciente.Regimen}-" +
                $"{paciente.FechaNacimiento}-{paciente.FechaIngreso}-{paciente.EPS}-{paciente.NroIngreso}-{paciente.MotivoIngreso}-{paciente.ResultadoRevision} -" +
                $"{paciente.TipoTratamiento}-{paciente.FormaRealizacion}-{paciente.Diagnostico}-{paciente.MedicoCargo}-" +
                $"{paciente.Observaciones}";

            // Escribe los datos en el archivo de texto
            using (StreamWriter sw = new StreamWriter(rutaArchivo, true))
            {
                sw.WriteLine(datos);
            }
        }

        public void ActualizarPersona(Paciente paciente)
        {
            string datosExistentes = File.ReadAllText(rutaArchivo);

            string[] campos = datosExistentes.Split('-');
            campos[0] = paciente.Cedula;
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


        public Paciente BuscarPorCedula(String Cedula)
        {
            string ced = Cedula;
            Paciente datos = new Paciente();
            StreamReader Lectura;
            string Cadena;
            bool encontrado;
            encontrado = false;
            char[] separador = { '-' };
            Lectura = File.OpenText("Registro medico.txt");
            //string[] lineas = File.ReadAllLines(rutaArchivo);
            Cadena = Lectura.ReadLine();
            while (Cadena != null && encontrado == false)
            {
                string[] campos = Cadena.Split(separador);
                if (campos[0].Equals(Cedula))
                {
                    Console.WriteLine(ced);
                    datos.Cedula = campos[0];
                    datos.Nombre = campos[1];
                    datos.Telefono = campos[2];
                    datos.Edad = Convert.ToInt32(campos[3]);
                    datos.Direccion = campos[4];
                    datos.Sexo = Convert.ToChar(campos[5]);
                    datos.Estrato = Convert.ToInt16(campos[6]);
                    datos.Regimen = campos[7];
                    datos.FechaNacimiento = Convert.ToDateTime(campos[8]);
                    datos.FechaIngreso = Convert.ToDateTime(campos[9]);
                    datos.EPS = campos[10];
                    datos.NroIngreso = Convert.ToInt16(campos[11]);
                    datos.MotivoIngreso = campos[12];
                    datos.ResultadoRevision = campos[13];
                    datos.TipoTratamiento = campos[14];
                    datos.FormaRealizacion = campos[15];
                    datos.Diagnostico = campos[16];
                    datos.MedicoCargo = campos[17];
                    datos.Observaciones = campos[18];
                    encontrado = true;
                }
                else
                {
                    Cadena = Lectura.ReadLine(); 
                };
                
            }
            if (encontrado == true) { return datos; } else { return null; }

        }

    }
        
}   

