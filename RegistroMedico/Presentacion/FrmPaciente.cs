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
        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            Focus();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente();
            ValidarCampos();
            paciente.Cedula = txtCedula.Text;
            paciente.Nombre = txtNombre.Text;
            paciente.Telefono = txtTelefono.Text;
            paciente.Edad = int.Parse(txtEdad.Text);
            paciente.Direccion = txtDireccion.Text;
            paciente.Sexo = char.Parse(cbSexo.Text);
            paciente.Estrato = int.Parse(cbEstrato.Text);
            paciente.Regimen = cbRegimen.Text;
            paciente.FechaNacimiento = DateTime.Parse(dtpFechaNacimiento.Text);
            paciente.FechaIngreso = DateTime.Parse(dtpFechaIngreso.Text);
            paciente.EPS = cbEps.Text;
            paciente.NroIngreso = int.Parse(txtNroIngreso.Text);
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
          
            txtCedula.Focus();
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
        private bool ValidarCampos()
        {
            bool ok = true;
            if (txtCedula.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtCedula, " ");
            }
            if (txtNombre.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNombre, " ");
            }
            if (txtTelefono.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtTelefono, " ");
            }
            if (txtEdad.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtEdad, " ");
            }
            if (txtDireccion.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtDireccion, " ");
            }
            if (cbSexo.Text == "")
            {
                ok = false;
                errorProvider1.SetError(cbSexo, " ");
            }
            if (cbEstrato.Text == "")
            {
                ok = false;
                errorProvider1.SetError(cbEstrato, " ");
            }
            if (cbRegimen.Text == "")
            {
                ok = false;
                errorProvider1.SetError(cbRegimen, " ");
            }
            if (cbEps.Text == "")
            {
                ok = false;
                errorProvider1.SetError(cbEps, " ");
            }
            if (txtNroIngreso.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNroIngreso, " ");
            }
            if (txtMotivoIngreso.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtMotivoIngreso, " ");
            }
            if (txtResultadoRevision.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtResultadoRevision, " ");
            }
            if (txtTipoTratamiento.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtTipoTratamiento, " ");
            }
            if (txtFormaRealizacion.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtFormaRealizacion, " ");
            }
            if (txtDiagnostico.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtDiagnostico, " ");
            }
            if (txtMedicoCargo.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtMedicoCargo, " ");
            }
            if (txtObservaciones.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtObservaciones, " ");
            }

            return ok;
        }

        private void btnDiagnostico_Click(object sender, EventArgs e)
        {
            //FrmHistoriaClinica form = new FrmHistoriaClinica();
            //form.Show();
            AbrirFormularioHistoriaClinica(new FrmHistoriaClinica());
        }

        void AbrirFormularioHistoriaClinica(FrmHistoriaClinica f)
        {
            this.Hide();
            f.ShowDialog(this);
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

       

        private void FrmPaciente_Load(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int CedulaNueva = Convert.ToInt32(txtCedula.Text);
            string NombreNuevo = txtNombre.Text;
            int TelefonoNuevo = Convert.ToInt32(txtTelefono.Text);
            int EdadNueva = Convert.ToInt32(txtEdad.Text);
            string DireccionNueva = txtDireccion.Text;
            char SexoNuevo = Convert.ToChar(cbSexo);
            char EstartoNuevo = Convert.ToChar(cbEstrato.Text);
            string RegimenNuevo = cbRegimen.Text;
            DateTime FechaNacimientoNueva = Convert.ToDateTime(dtpFechaNacimiento.Text);
            DateTime FehaIngresoNueva = Convert.ToDateTime(dtpFechaIngreso.Text);
            string EpsNueva = cbEps.Text;
            int NroIngresoNuevo = Convert.ToInt32(txtNroIngreso.Text);
            string MotivoIngresoNuevo = txtMotivoIngreso.Text;
            string ResultadoRevisionNueva = txtResultadoRevision.Text;
            string TipoTratamientoNuevo = txtTipoTratamiento.Text;
            string FormaRealizacionNueva = txtFormaRealizacion.Text;
            string DiagnosticoNuevo = txtDiagnostico.Text;
            MotivoIngresoNuevo = txtMotivoIngreso.Text;
            MotivoIngresoNuevo = txtMotivoIngreso.Text;

            MessageBox.Show("El registro se actualizo correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       
    }
}
