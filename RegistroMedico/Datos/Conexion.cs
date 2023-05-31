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

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT A.cedula, A.nombre, A.direccion, A.telefono, A.edad, A.sexo, A.estrato, A.regimen, " +
                                      "A.fecha_nacimiento, B.fecha_ingreso, A.eps, B.nro_ingreso, B.motivo_ingreso, " +
                                      "B.resultado_revision, B.tipo_tratamiento, B.forma_realizacion, B.diagnostico, B.medico_cargo, B.observaciones" +
                                "FROM pacientes A JOIN historias_clinicas B ON A.cedula = B.cedula;";
                OracleCommand command = new OracleCommand(query, connection);
                command.Parameters.Add(new OracleParameter(":nombre", cedula));

                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {

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

                    }
                }
            }

            return paciente;
        }

        public void Agregar(Paciente paciente)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                //connection.Open();
                //connection.CreateCommand();
                
               

                OracleCommand command = new OracleCommand("GUARDAR",connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("pCedula", OracleDbType.Varchar2).Value = paciente.Cedula;
                command.Parameters.Add("pNombre", OracleDbType.Varchar2).Value = paciente.Nombre;
                command.Parameters.Add("pTelefono", OracleDbType.Varchar2).Value = paciente.Telefono;
                command.Parameters.Add("pEdad", OracleDbType.Varchar2).Value = paciente.Edad;
                command.Parameters.Add("pDireccion", OracleDbType.Varchar2).Value = paciente.Direccion;
                command.Parameters.Add("pSexo", OracleDbType.Char).Value = paciente.Sexo;
                command.Parameters.Add("pEstrato", OracleDbType.Varchar2).Value = paciente.Estrato;
                command.Parameters.Add("pFechaNacimiento", OracleDbType.Date).Value = paciente.FechaNacimiento;
                command.Parameters.Add("hFechaIngreso", OracleDbType.Date).Value = paciente.FechaIngreso;
                command.Parameters.Add("pEps", OracleDbType.Varchar2).Value = paciente.EPS;
                command.Parameters.Add("hNroIngreso", OracleDbType.Varchar2).Value = paciente.NroIngreso;
                command.Parameters.Add("hMotivoIngreso", OracleDbType.Varchar2).Value = paciente.MotivoIngreso;
                command.Parameters.Add("hTipoTratamiento", OracleDbType.Varchar2).Value = paciente.TipoTratamiento;
                command.Parameters.Add("hFormaRealizacion", OracleDbType.Varchar2).Value = paciente.FormaRealizacion;
                command.Parameters.Add("hDiagnostico", OracleDbType.Varchar2).Value = paciente.Diagnostico;
                command.Parameters.Add("hMedicoCargo", OracleDbType.Varchar2).Value = paciente.MedicoCargo;
                command.Parameters.Add("hObservaciones", OracleDbType.Varchar2).Value = paciente.Observaciones;



                //command.CommandType= System.Data.CommandType.StoredProcedure;
                //command.Parameters.Add(new OracleParameter(":cedula", paciente.Cedula));
                //command.Parameters.Add(new OracleParameter(":nombre", paciente.Nombre));
                //command.Parameters.Add(new OracleParameter(":telefono", paciente.Telefono));
                //command.Parameters.Add(new OracleParameter(":edad", paciente.Edad));
                //command.Parameters.Add(new OracleParameter(":direccion", paciente.Direccion));
                //command.Parameters.Add(new OracleParameter(":sexo", paciente.Sexo));
                //command.Parameters.Add(new OracleParameter(":fecha_nacimiento", paciente.FechaNacimiento));
                //command.Parameters.Add(new OracleParameter(":estrato", paciente.Estrato));
                //command.Parameters.Add(new OracleParameter(":regimen", paciente.Regimen));
                //command.Parameters.Add(new OracleParameter(":nro_ingreso", paciente.NroIngreso));
                //command.Parameters.Add(new OracleParameter(":fecha_ingreso", paciente.FechaIngreso));
                //command.Parameters.Add(new OracleParameter(":motivo_ingreso", paciente.MotivoIngreso));
                //command.Parameters.Add(new OracleParameter(":resultado_revision", paciente.ResultadoRevision));
                //command.Parameters.Add(new OracleParameter(":tipo_tratamiento", paciente.TipoTratamiento));
                //command.Parameters.Add(new OracleParameter(":forma_realizacion", paciente.FormaRealizacion));
                //command.Parameters.Add(new OracleParameter(":medico_cargo", paciente.MedicoCargo));
                //command.Parameters.Add(new OracleParameter(":diagnostico", paciente.Diagnostico));
                //command.Parameters.Add(new OracleParameter(":observaciones", paciente.Observaciones));
                //command.Parameters.Add(new OracleParameter(":cedula", paciente.Cedula));

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

                string query = "UPDATE Pacientes SET Cedula = :cedula, Nombre = :nombre, Telefono = :telefono, Edad = :edad, Direccion = :direccion, Sexo = :sexo," +
                               "Fecha_nacimiento = :fecha_nacimiento, Estrato = :estrato, Regimen = :regimen WHERE Cedula = :cedula;" +
                    
                               "UPDATE Histrorias_clinicas SET Nro_ingreso = :nro_ingreso, Fecha_ingreso = :fecha_ingreso, Motivo_ingreso = :motivo_ingreso," +
                               "Resultado_revision = :resultado_revision, Tipo_tratamiento = :tipo_tratamiento, Forma_realizacion = :forma_realizacion," +
                               "Medico_cargo = :medico_cargo, Diagnostico = :diagnostico, Observaciones = :observaciones, Cedula = :cedula WHERE Nro_ingreso = :nro_ingreso;";
                
                OracleCommand command = new OracleCommand(query, connection);
                command.Parameters.Add(new OracleParameter(":cedula", paciente.Cedula));
                command.Parameters.Add(new OracleParameter(":nombre", paciente.Nombre));
                command.Parameters.Add(new OracleParameter(":telefono", paciente.Telefono));
                command.Parameters.Add(new OracleParameter(":edad", paciente.Edad));
                command.Parameters.Add(new OracleParameter(":direccion", paciente.Direccion));
                command.Parameters.Add(new OracleParameter(":sexo", paciente.Sexo));
                command.Parameters.Add(new OracleParameter(":fecha_nacimiento", paciente.FechaNacimiento));
                command.Parameters.Add(new OracleParameter(":estrato", paciente.Estrato));
                command.Parameters.Add(new OracleParameter(":regimen", paciente.Regimen));
                command.Parameters.Add(new OracleParameter(":nro_ingreso", paciente.NroIngreso));
                command.Parameters.Add(new OracleParameter(":fecha_ingreso", paciente.FechaIngreso));
                command.Parameters.Add(new OracleParameter(":motivo_ingreso", paciente.MotivoIngreso));
                command.Parameters.Add(new OracleParameter(":resultado_revision", paciente.ResultadoRevision));
                command.Parameters.Add(new OracleParameter(":tipo_tratamiento", paciente.TipoTratamiento));
                command.Parameters.Add(new OracleParameter(":forma_realizacion", paciente.FormaRealizacion));
                command.Parameters.Add(new OracleParameter(":medico_cargo", paciente.MedicoCargo));
                command.Parameters.Add(new OracleParameter(":diagnostico", paciente.Diagnostico));
                command.Parameters.Add(new OracleParameter(":observaciones", paciente.Observaciones));
                command.Parameters.Add(new OracleParameter(":cedula", paciente.Cedula));

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public void Eliminar(string cedula )
        {
            
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                
                connection.Open();

                string query = "DELETE FROM Pacientes WHERE Cedula = :cedula;" +
                               "DELETE FROM Historias_clinicas WHERE Cedula = :cedula;";
                OracleCommand command = new OracleCommand(query, connection);
                command.Parameters.Add(new OracleParameter(":cedula", cedula));
                command.Parameters.Add(new OracleParameter(":cedula", cedula));
                //command.Parameters.Add(new OracleParameter(":nro_ingreso", nro_ingreso));

                command.ExecuteNonQuery();

                connection.Close();
            }
        }
    }
}

