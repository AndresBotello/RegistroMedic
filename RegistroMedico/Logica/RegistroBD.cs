using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class RegistroBD
    {
        private Conexion conexion = new Conexion();

        public Paciente BuscarPacientePorCedula(string cedula)
        {
           
            return conexion.BuscarPorCedula(cedula);
        }


        public void AgregarPaciente(Paciente paciente)
        {
            
            conexion.Agregar(paciente);
        }

        public void ActualizarPaciente(Paciente paciente)
        {
            
            conexion.Actualizar(paciente);
        }

        public void EliminarPaciente(string cedula)
        {
            
            conexion.Eliminar(cedula/*, nro_ingreso*/);
        }
    }
}

