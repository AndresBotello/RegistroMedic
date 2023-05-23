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

        

        private void btnSalir3_Click(object sender, EventArgs e)
        {
            Salir3();
        }

        void Salir3()
        {
            this.Owner.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            //string Cedula = txtCedula.Text;

            //Paciente pacienteEncontrado = Paciente.BuscarPorCedula(cedula);

            //if (pacienteEncontrado != null)
            //{
            //    txtNombre.Text = pacienteEncontrado.Nombre;
            //    txtTelefono.Text = pacienteEncontrado.Telefono.ToString();
            //    txtEdad.Text = pacienteEncontrado.Edad.ToString();
            //    txtDireccion.Text = pacienteEncontrado.Direccion;
            //    txtSexo.Text = pacienteEncontrado.Sexo.ToString();
            //    txtEstrato.Text = pacienteEncontrado.Estrato.ToString();
            //    txtRegimen.Text = pacienteEncontrado.Regimen;
            //    txtFechaNacimiento = pacienteEncontrado.FechaNacimiento.ToShortTimeString();
            //    txtFechaIngreso.Text = pacienteEncontrado.FechaIngreso.ToShortTimeString();
            //    txtEps.Text = pacienteEncontrado.EPS;
            //    txtNroIngreso.Text = pacienteEncontrado.NroIngreso.ToString();
            //    txtResultadoRevision.Text = pacienteEncontrado.ResultadoRevision;
            //    txtTipoTratamiento.Text = pacienteEncontrado.TipoTratamiento;
            //    txtFormaRealizacion.Text = pacienteEncontrado.FormaRealizacion;
            //    txtDiagnostico.Text = pacienteEncontrado.Diagnostico;
            //    txtMedicoCargo.Text = pacienteEncontrado.MedicoCargo;
            //    txtObservaciones.Text = pacienteEncontrado.Observaciones;
            //}
            //else
            //{
            //    MessageBox.Show("No se encontró la cédula.");
            //}
        }
    }
}
