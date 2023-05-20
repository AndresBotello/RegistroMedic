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
        string ruta = "Registro medico.txt";

        public string GuardarRegistro(Paciente paciente)
        {
            var sw = new StreamWriter(ruta, true);
            sw.WriteLine(paciente.ToString());
            sw.Close();
            return "Ok";
        }

        public List<Paciente> ConsultarTodos()
        {
            List<Paciente> lista = new List<Paciente>();
            try
            {
                var sr = new StreamReader(ruta);
                while (true)
                {
                    lista.Add(Mapeador(sr.ReadLine()));
                }
            }
            catch (Exception)
            {

                return null;
            }
        }

        Paciente Mapeador(string linea)
        {
            var paciente = new Paciente();
            paciente.Cedula = int.Parse(linea.Split(' ; ')[0]);
            paciente.Nombre = linea.Split(' ; ')[1];
            paciente.Telefono
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
