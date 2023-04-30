using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Archivo
    {
        private readonly string rutaArchivo = "Registro medico.txt";

        public void AgregarRegistro(Registro registro) 
        {
            using (StreamWriter writer = new StreamWriter(rutaArchivo, true)) 
            {
                writer.WriteLine($"{}");
            }
        }

    }
}
