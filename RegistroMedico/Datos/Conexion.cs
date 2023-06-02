using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace Datos
{
    public class Conexion
    {
        private string connectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)" +
                                          "(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)))" +
                                          ";User Id=eder3012;Password=12345;";

        public Paciente BuscarPorCedula(string cedula)
        {
            Paciente paciente = null;

            OracleConnection connection = new OracleConnection(connectionString);
            
               

               

                string query = $"SELECT * FROM vistapacientes";
                OracleCommand command = new OracleCommand(query, connection);
            command.CommandType = CommandType.Text;
            
            connection.Open();
            OracleDataReader reader;
             reader= command.ExecuteReader();
               
                reader.Read();
                        paciente = new Paciente();
                        paciente.Cedula = reader["Cedula"].ToString();
                        paciente.Nombre = reader["Nombre"].ToString();
                        paciente.Telefono = reader["Telefono"].ToString();
                        paciente.Direccion = reader["Direccion"].ToString();
                        paciente.Edad = Convert.ToInt16(reader["Edad"]);
                        paciente.Sexo = Convert.ToChar(reader["Sexo"]);
                        paciente.Estrato = Convert.ToInt16(reader["Estrato"]);
                        paciente.Regimen = reader["Regimen"].ToString();
                        paciente.FechaNacimiento = Convert.ToDateTime(reader["Fecha_nacimiento"]);
                        paciente.FechaIngreso = Convert.ToDateTime(reader["Fecha_ingreso"]);
                        paciente.EPS = reader["Eps"].ToString();
                        paciente.NroIngreso = Convert.ToInt16(reader["Nro_ingreso"]);
                        paciente.MotivoIngreso = reader["Motivo_ingreso"].ToString();
                        paciente.ResultadoRevision = reader["Resultado_revision"].ToString();
                        paciente.TipoTratamiento = reader["Tipo_tratamiento"].ToString();
                        paciente.FormaRealizacion = reader["Forma_realizacion"].ToString();
                        paciente.Diagnostico = reader["Diagnostico"].ToString();
                        paciente.MedicoCargo = reader["Medico_cargo"].ToString();
                        paciente.Observaciones = reader["Observaciones"].ToString();

            
            connection.Close();
            return paciente;
        }

        public void Agregar(Paciente paciente)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                
                OracleCommand command = new OracleCommand("GUARDAR",connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("pCedula", OracleDbType.Varchar2).Value = paciente.Cedula;
                command.Parameters.Add("pNombre", OracleDbType.Varchar2).Value = paciente.Nombre;
                command.Parameters.Add("pTelefono", OracleDbType.Varchar2).Value = paciente.Telefono;
                command.Parameters.Add("pEdad", OracleDbType.Varchar2).Value = paciente.Edad;
                command.Parameters.Add("pDireccion", OracleDbType.Varchar2).Value = paciente.Direccion;
                command.Parameters.Add("pSexo", OracleDbType.Char).Value = paciente.Sexo;
                command.Parameters.Add("pEstrato", OracleDbType.Varchar2).Value = paciente.Estrato;
                command.Parameters.Add("pRegimen", OracleDbType.Varchar2).Value = paciente.Regimen;
                command.Parameters.Add("pFechaNacimiento", OracleDbType.Date).Value = paciente.FechaNacimiento;
                command.Parameters.Add("hFechaIngreso", OracleDbType.Date).Value = paciente.FechaIngreso;
                command.Parameters.Add("pEps", OracleDbType.Varchar2).Value = paciente.EPS;
                command.Parameters.Add("hNroIngreso", OracleDbType.Varchar2).Value = paciente.NroIngreso;
                command.Parameters.Add("hMotivoIngreso", OracleDbType.Varchar2).Value = paciente.MotivoIngreso;
                command.Parameters.Add("hResultadoRevision", OracleDbType.Varchar2).Value = paciente.ResultadoRevision;
                command.Parameters.Add("hTipoTratamiento", OracleDbType.Varchar2).Value = paciente.TipoTratamiento;
                command.Parameters.Add("hFormaRealizacion", OracleDbType.Varchar2).Value = paciente.FormaRealizacion;
                command.Parameters.Add("hDiagnostico", OracleDbType.Varchar2).Value = paciente.Diagnostico;
                command.Parameters.Add("hMedicoCargo", OracleDbType.Varchar2).Value = paciente.MedicoCargo;
                command.Parameters.Add("hObservaciones", OracleDbType.Varchar2).Value = paciente.Observaciones;

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public void Actualizar(Paciente paciente)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();

               
                OracleCommand command = new OracleCommand("ACTUALIZAR", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("pCedula", OracleDbType.Varchar2).Value = paciente.Cedula;
                command.Parameters.Add("pNombre", OracleDbType.Varchar2).Value = paciente.Nombre;
                command.Parameters.Add("pTelefono", OracleDbType.Varchar2).Value = paciente.Telefono;
                command.Parameters.Add("pEdad", OracleDbType.Varchar2).Value = paciente.Edad;
                command.Parameters.Add("pDireccion", OracleDbType.Varchar2).Value = paciente.Direccion;
                command.Parameters.Add("pSexo", OracleDbType.Char).Value = paciente.Sexo;
                command.Parameters.Add("pEstrato", OracleDbType.Varchar2).Value = paciente.Estrato;
                command.Parameters.Add("pRegimen", OracleDbType.Varchar2).Value = paciente.Regimen;
                command.Parameters.Add("pFechaNacimiento", OracleDbType.Date).Value = paciente.FechaNacimiento;
                command.Parameters.Add("hFechaIngreso", OracleDbType.Date).Value = paciente.FechaIngreso;
                command.Parameters.Add("pEps", OracleDbType.Varchar2).Value = paciente.EPS;
                command.Parameters.Add("hNroIngreso", OracleDbType.Varchar2).Value = paciente.NroIngreso;
                command.Parameters.Add("hMotivoIngreso", OracleDbType.Varchar2).Value = paciente.MotivoIngreso;
                command.Parameters.Add("hResultadoRevision", OracleDbType.Varchar2).Value = paciente.ResultadoRevision;
                command.Parameters.Add("hTipoTratamiento", OracleDbType.Varchar2).Value = paciente.TipoTratamiento;
                command.Parameters.Add("hFormaRealizacion", OracleDbType.Varchar2).Value = paciente.FormaRealizacion;
                command.Parameters.Add("hDiagnostico", OracleDbType.Varchar2).Value = paciente.Diagnostico;
                command.Parameters.Add("hMedicoCargo", OracleDbType.Varchar2).Value = paciente.MedicoCargo;
                command.Parameters.Add("hObservaciones", OracleDbType.Varchar2).Value = paciente.Observaciones;
               

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public void Eliminar(Paciente paciente )
        {
            
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                
                connection.Open();

                OracleCommand command = new OracleCommand("ELIMINARDATOS", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("pCedula", OracleDbType.Varchar2).Value = paciente.Cedula;
                command.Parameters.Add("pCedula", OracleDbType.Varchar2).Value = paciente.Cedula;


               
                command.ExecuteNonQuery();

                connection.Close();
            }
        }
    }
}

