using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Presentacion
{
    public partial class FrmHistoriaClinica : Form
    {
        private RegistroPaciente registroPaciente;

        private RegistroBD registroBD = new RegistroBD();
        public FrmHistoriaClinica()
        {
            InitializeComponent();
            registroPaciente = new RegistroPaciente();
            btnBuscar.Click += btnBuscar_Click;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmHistoriaClinica_Load(object sender, EventArgs e)
        {

        }

        

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }

        void Salir()
        {
            this.Owner.Show();
            this.Close();
        }

       

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string cedula = txtBuscar.Text;

            Paciente paciente = registroBD.BuscarPacientePorCedula(cedula);

            if (paciente != null)
            {
                

                txtCedula.Text = paciente.Cedula.ToString();
                txtNombre.Text = paciente.Nombre;
                txtDireccion.Text = paciente.Direccion;
                txtTelefono.Text = paciente.Telefono.ToString();
                txtEdad.Text = paciente.Edad.ToString();
                txtSexo.Text = paciente.Sexo.ToString();
                txtEstrato.Text = paciente.Estrato.ToString();
                txtRegimen.Text = paciente.Regimen;
                txtFechaNacimiento.Text = paciente.FechaNacimiento.ToString();
                txtFechaIngreso.Text = paciente.FechaIngreso.ToString();
                txtEps.Text = paciente.EPS;
                txtNroIngreso.Text = paciente.NroIngreso.ToString();
                txtMotivoIngreso.Text = paciente.MotivoIngreso;
                txtResultadoRevision.Text = paciente.ResultadoRevision;
                txtTipoTratamiento.Text = paciente.TipoTratamiento;
                txtFormaRealizacion.Text = paciente.FormaRealizacion;
                txtDiagnostico.Text = paciente.Diagnostico;
                txtMedicoCargo.Text = paciente.MedicoCargo;
                txtObservaciones.Text = paciente.Observaciones;

            }
            else
            {
                MessageBox.Show("No se encontro paciente con ese cedula.");
            }
        }

        private void VerPaciente(Paciente pacienteEncontrado)
        {
            txtCedula.Text = pacienteEncontrado.Cedula.ToString();
            txtNombre.Text = pacienteEncontrado.Nombre;
            txtTelefono.Text = pacienteEncontrado.Telefono.ToString();
            txtEdad.Text = pacienteEncontrado.Edad.ToString();
            txtDireccion.Text = pacienteEncontrado.Direccion;
            txtSexo.Text = pacienteEncontrado.Sexo.ToString();
            txtEstrato.Text = pacienteEncontrado.Estrato.ToString();
            txtRegimen.Text = pacienteEncontrado.Regimen;
            txtFechaNacimiento.Text = pacienteEncontrado.FechaNacimiento.ToShortDateString();
            txtFechaIngreso.Text = pacienteEncontrado.FechaIngreso.ToString("F");
            txtEps.Text = pacienteEncontrado.EPS;
            txtNroIngreso.Text = pacienteEncontrado.NroIngreso.ToString();
            txtMotivoIngreso.Text = pacienteEncontrado.MotivoIngreso.ToString();
            txtResultadoRevision.Text = pacienteEncontrado.ResultadoRevision;
            txtTipoTratamiento.Text = pacienteEncontrado.TipoTratamiento;
            txtFormaRealizacion.Text = pacienteEncontrado.FormaRealizacion;
            txtDiagnostico.Text = pacienteEncontrado.Diagnostico;
            txtMedicoCargo.Text = pacienteEncontrado.MedicoCargo;
            txtObservaciones.Text = pacienteEncontrado.Observaciones;
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string cedula = txtBuscar.Text;
            Paciente paciente = registroBD.BuscarPacientePorCedula(cedula);

            if (paciente != null)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar esta persona?", "Confirmación", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    registroBD.EliminarPaciente(cedula);

                    MessageBox.Show("Persona eliminada correctamente.");
                    LimpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("No se encontró ninguna persona con la cédula especificada.");
                LimpiarCampos();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string cedula = txtBuscar.Text;
            Paciente paciente = registroBD.BuscarPacientePorCedula(cedula);

            if (paciente != null)
            {
                paciente.Cedula = txtCedula.Text;
                paciente.Nombre = txtNombre.Text;
                paciente.Direccion = txtDireccion.Text;
                paciente.Telefono = txtTelefono.Text;
                paciente.Edad = Convert.ToInt16(txtEdad.Text);
                paciente.Sexo = Convert.ToChar(txtSexo.Text);
                paciente.Estrato = Convert.ToInt16(txtEstrato.Text);
                paciente.Regimen = txtRegimen.Text;
                paciente.FechaNacimiento = Convert.ToDateTime(txtFechaNacimiento.Text);
                paciente.FechaIngreso = Convert.ToDateTime(txtFechaIngreso.Text);
                paciente.EPS = txtEps.Text;
                paciente.NroIngreso = Convert.ToInt16(txtNroIngreso.Text);
                paciente.MotivoIngreso = txtMotivoIngreso.Text;
                paciente.ResultadoRevision = txtResultadoRevision.Text;
                paciente.TipoTratamiento = txtTipoTratamiento.Text;
                paciente.FormaRealizacion = txtFormaRealizacion.Text;
                paciente.Diagnostico = txtDiagnostico.Text;
                paciente.MedicoCargo = txtMedicoCargo.Text;
                paciente.Observaciones = txtObservaciones.Text;
                // Asignar otros valores a la persona

                registroBD.ActualizarPaciente (paciente);

                MessageBox.Show("Persona actualizada correctamente.");
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("No se encontró ninguna persona con la cédula especificada.");
                LimpiarCampos();
            }
        }

        private void LimpiarCampos()
        {
            txtCedula.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtEdad.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtSexo.Text = string.Empty;
            txtEstrato.Text = string.Empty;
            txtRegimen.Text = string.Empty;
            txtFechaNacimiento.Text = string.Empty;
            txtFechaIngreso.Text = string.Empty;
            txtEps.Text = string.Empty;
            txtNroIngreso.Text = string.Empty;
            txtMotivoIngreso.Text = string.Empty;
            txtResultadoRevision.Text = string.Empty;
            txtTipoTratamiento.Text = string.Empty;
            txtFormaRealizacion.Text = string.Empty;
            txtDiagnostico.Text = string.Empty;
            txtMedicoCargo.Text = string.Empty;
            txtObservaciones.Text = string.Empty;
        }
    }
}
