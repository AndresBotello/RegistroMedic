using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Registro
    {
        private Archivo datos;

        public Registro() 
        {
            datos = new Archivo();
        }

        public bool AgregarPaciente(int cedula, string nombre, int telefono, int edad, string direccion, char sexo)
        {
            if (int.IsNullOrEmpty(cedula) || string.IsNullOrEmpty(nombre) || int.IsNullOrEmpty(telefono) || int.IsNullOrEmpty(edad) || string.IsNullOrEmpty(direccion) || char.IsNullOrEmpty(sexo))
            {
                return false;
            }

            Paciente paciente = new Paciente
            {
                Cedula = cedula,
                Nombre = nombre,
                Telefono = telefono,
                Edad = edad,
                Direccion = direccion,
                Sexo = sexo
            };

            datos.AgregarPaciente(paciente);

            return true;
        }
    }
}
