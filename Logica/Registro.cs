using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Registro : ICRUD<Paciente>
    {
        private Archivo datos;

        public void AgregarRegistro(Paciente paciente)
        {
            datos.AgregarPaciente(paciente);
        }
        public string ActualizarRegistro(Paciente paciente)
        {
            throw new NotImplementedException();
        }

        public string EliminarRegistro(Paciente paciente)
        {
            throw new NotImplementedException();
        }

        string ICRUD<Paciente>.AgregarRegistro(Paciente paciente)
        {
            throw new NotImplementedException();
        }
    }
}
