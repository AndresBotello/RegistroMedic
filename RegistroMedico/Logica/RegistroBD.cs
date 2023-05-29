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

        public List<Paciente> ObtenerTodos()
        {
            return conexion.ObtenerTodos();
        }

        public void AgregarUsuario(Paciente paciente)
        {
            // Realizar validaciones o lógica adicional antes de llamar al método en UsuarioDAO
            conexion.Agregar(paciente);
        }

        public void ActualizarUsuario(Paciente paciente)
        {
            // Realizar validaciones o lógica adicional antes de llamar al método en UsuarioDAO
            conexion.Actualizar(paciente);
        }

        public void EliminarUsuario(string cedula)
        {
            // Realizar validaciones o lógica adicional antes de llamar al método en UsuarioDAO
            conexion.Eliminar(cedula);
        }
    }
}
}
