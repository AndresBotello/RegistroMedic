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
    public partial class FrmPaciente : Form
    {
        private RegistroPaciente registro;
        public FrmPaciente()
        {
            InitializeComponent();
            registro = new RegistroPaciente("Registro medico.txt");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Registro logica = new Registro();

            //if (logica.AgregarPaciente(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, comboBox1.Text))
            //{
            //    MessageBox.Show("El cliente se agregó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    MessageBox.Show("Debe ingresar todos los datos del cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            //FrmHistoria form = new FrmHistoria();
            //form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Salir();
        }

        void Salir()
        {
            this.Owner.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente();

            paciente.Cedula = int.Parse(txtCedula.Text);
            paciente.Nombre = txtNombre.Text;
            paciente.Telefono = int.Parse(txtTelefono.Text);
            paciente.Edad = int.Parse(txtEdad.Text);
            paciente.Direccion = txtDireccion.Text;
            paciente.Sexo = char.Parse(cbSexo.Text);
            paciente.Estrato = int.Parse(cbEstrato.Text);
            paciente.Regimen = cbRegimen.Text;
            paciente.FechaNacimiento = DateTime.Parse(dtpFechaNacimiento.Text);
            paciente.FechaIngreso = DateTime.Parse(dtpFechaIngreso.Text);
            paciente.MotivoIngreso = txtMotivoIngreso.Text;
            paciente.ResultadoRevision = txtResultadoRevision.Text;
            paciente.TipoTratamiento = txtTipoTratamiento.Text;
            paciente.FormaRealizacion = txtFormaRealizacion.Text;
            paciente.Diagnostico = txtDiagnostico.Text;
            paciente.MedicoCargo = txtMedicoCargo.Text;
            paciente.Observaciones = txtObservaciones.Text;

            registro.GuardarPaciente(paciente);

            MessageBox.Show("El paciente se agregó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            txtMotivoIngreso.Text = string.Empty;
            txtResultadoRevision.Text = string.Empty;
            txtTipoTratamiento.Text = string.Empty;
            txtFormaRealizacion.Text = string.Empty;
            txtDiagnostico.Text = string.Empty;
            txtMedicoCargo.Text = string.Empty;
            txtObservaciones.Text = string.Empty;



        }

        private void btnDiagnostico_Click(object sender, EventArgs e)
        {
            FrmHistoriaClinica form = new FrmHistoriaClinica();
            form.Show();
        }

        private void btnSalir2_Click(object sender, EventArgs e)
        {
            Salir2();
        }

        void Salir2()
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
