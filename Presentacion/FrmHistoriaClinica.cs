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
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmHistoriaClinica_Load(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string cedula = txtBuscar.Text;

            Paciente paciente = registroPaciente.BuscarPorCedula(cedula);

            if (paciente != null)
            {
                txtCedula.Text = paciente.Cedula.ToString();
                txtNombre.Text = paciente.Nombre;
                txtTelefono.Text = paciente.Telefono.ToString();
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
                MessageBox.Show("No se encontraron datos para la cédula ingresada.");
            }
        }

        private void btnSalir3_Click(object sender, EventArgs e)
        {
            Salir3();
        }

        void Salir3()
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
