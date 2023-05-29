using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace Datos
{
    public class Conexion
    {
        private string connectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)" +
                                          "(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)))" +
                                          ";User Id=eder3012;Password=12345;";

        public List<Paciente> ObtenerTodos()
        {
            List<Paciente> usuarios = new List<Paciente>();

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Usuarios";
                OracleCommand command = new OracleCommand(query, connection);

                using (OracleDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Paciente usuario = new Paciente();
                        //usuario.Id = Convert.ToInt32(reader["Id"]);
                        usuario.Nombre = reader["Nombre"].ToString();
                        usuario.Telefono = reader["Telefono"].ToString();

                        usuarios.Add(usuario);
                    }
                }
            }

            return usuarios;
        }

        public void Agregar(Paciente paciente)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Usuarios (Nombre, Email) VALUES (:nombre, :email)";
                OracleCommand command = new OracleCommand(query, connection);
                command.Parameters.Add(new OracleParameter(":nombre", paciente.Nombre));
                command.Parameters.Add(new OracleParameter(":email", paciente.Telefono));

                command.ExecuteNonQuery();
            }
        }

        public void Actualizar(Paciente paciente)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE Usuarios SET Nombre = :nombre, Email = :email WHERE Id = :id";
                OracleCommand command = new OracleCommand(query, connection);
                command.Parameters.Add(new OracleParameter(":nombre", paciente.Nombre));
                command.Parameters.Add(new OracleParameter(":email", paciente.Telefono));
                command.Parameters.Add(new OracleParameter(":id", paciente.Direccion));

                command.ExecuteNonQuery();
            }
        }

        public void Eliminar(string cedula)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM Pacientes WHERE Cedula = :cedula" +
                               "DELETE FROM Historias_clinicas WHERE Cedula = :cedula";
                OracleCommand command = new OracleCommand(query, connection);
                command.Parameters.Add(new OracleParameter(":cedula", cedula));

                command.ExecuteNonQuery();
            }
        }
    }
}
}
