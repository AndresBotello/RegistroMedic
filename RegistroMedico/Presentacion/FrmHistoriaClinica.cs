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
    }
}
