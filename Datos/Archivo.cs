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
                writer.WriteLine($"{paciente.Cedula},{paciente.Nombre},{paciente.Telefono},{paciente.Edad},{paciente.Direccion},{paciente.Sexo}, {paciente.Estrato}" +
                    $"");
            }
        }

        //public void ActualizarPaciente(Paciente paciente)
        //{
        //    string tempArchivo = "temp.txt";
        //    using (StreamReader sr = new StreamReader(rutaArchivo))
        //    using (StreamWriter sw = new StreamWriter(tempArchivo))
        //    {
        //        string linea;
        //        while ((linea = sr.ReadLine()) != null)
        //        {
        //            string[] campos = linea.Split(',');
        //            string pacienteNombre = campos[0];
        //            string pacienteApellido = campos[1];

        //            if (pacienteNombre == nombre && pacienteApellido == apellido)
        //            {
        //                // Escribir la línea actualizada en el archivo temporal
        //                sw.WriteLine($"{nombre},{apellido},{edad}");
        //            }
        //            else
        //            {
        //                // Escribir las líneas que no requieren actualización en el archivo temporal
        //                sw.WriteLine(linea);
        //            }
        //        }
        //    }

        //    // Reemplazar el archivo original con el archivo temporal
        //    File.Delete(rutaArchivo);
        //    File.Move(tempArchivo, rutaArchivo);
        //}

    }

    //public void EliminarPaciente(string nombre, string apellido)
    //{
    //    string tempArchivo = "temp.txt";
    //    using (StreamReader sr = new StreamReader(rutaArchivo))
    //    using (StreamWriter sw = new StreamWriter(tempArchivo))
    //    {
    //        string linea;
    //        while ((linea = sr.ReadLine()) != null)
    //        {
    //            string[] campos = linea.Split(',');
    //            string pacienteNombre = campos[0];
    //            string pacienteApellido = campos[1];

    //            if (pacienteNombre == nombre && pacienteApellido == apellido)
    //            {
    //                // Saltar la línea que coincide con el paciente a eliminar
    //                continue;
    //            }

    //            // Escribir las líneas que no coinciden en el archivo temporal
    //            sw.WriteLine(linea);
    //        }
    //    }

    //    // Reemplazar el archivo original con el archivo temporal
    //    File.Delete(rutaArchivo);
    //    File.Move(tempArchivo, rutaArchivo);
    //}
}
