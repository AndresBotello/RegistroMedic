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


namespace Presentacion
{
    public partial class FrmHistoriaClinica : Form
    {
        private RegistroPaciente registroPaciente;

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

            string Cedula = txtBuscar.Text;

            Paciente pacienteEncontrado = registroPaciente.BuscarPorCedula(Cedula);

            if (pacienteEncontrado != null)
            {
                VerPaciente(pacienteEncontrado);
            }
            else
            {
                MessageBox.Show("No se encontró la cédula.");
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
            int usuarioId = Convert.ToInt32(dataGridViewUsuarios.SelectedRows[0].Cells["Id"].Value);

            usuarioService.EliminarUsuario(usuarioId);

            CargarUsuarios();
            LimpiarCampos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int usuarioId = Convert.ToInt32(dataGridViewUsuarios.SelectedRows[0].Cells["Id"].Value);

            Usuario usuario = new Usuario();
            usuario.Id = usuarioId;
            usuario.Nombre = textBoxNombre.Text;
            usuario.Email = textBoxEmail.Text;

            usuarioService.ActualizarUsuario(usuario);

            CargarUsuarios();
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtCedula.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtEdad.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            cbSexo.Text = string.Empty;
            cbEstrato.Text = string.Empty;
            cbRegimen.Text = string.Empty;
            dtpFechaNacimiento.Text = string.Empty;
            dtpFechaIngreso.Text = string.Empty;
            cbEps.Text = string.Empty;
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
