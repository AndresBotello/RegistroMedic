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

        private RegistroBD registroBD = new RegistroBD();
        public FrmPaciente()
        {
            InitializeComponent();
            registro = new RegistroPaciente("Registro medico.txt");
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
            paciente.Cedula = txtCedula.Text;
            paciente.Nombre = txtNombre.Text;
            paciente.Telefono = txtTelefono.Text;
            paciente.FechaNacimiento = DateTime.Parse(dtpFechaNacimiento.Text);
            paciente.Edad = int.Parse(txtEdad.Text);
            paciente.Sexo = char.Parse(cbSexo.Text);
            paciente.Direccion = txtDireccion.Text;
            paciente.Estrato = int.Parse(cbEstrato.Text);
            paciente.Regimen = cbRegimen.Text;
            paciente.FechaIngreso = DateTime.Now;
            paciente.EPS = cbEps.Text;
            paciente.NroIngreso = int.Parse(txtNroIngreso.Text);
            paciente.MotivoIngreso = txtMotivoIngreso.Text;
            paciente.ResultadoRevision = txtResultadoRevision.Text;
            paciente.TipoTratamiento = txtTipoTratamiento.Text;
            paciente.FormaRealizacion = txtFormaRealizacion.Text;
            paciente.Diagnostico = txtDiagnostico.Text;
            paciente.MedicoCargo = txtMedicoCargo.Text;
            paciente.Observaciones = txtObservaciones.Text;
            // Asignar otros valores a la persona

            registroBD.AgregarPaciente(paciente);

            MessageBox.Show("Paciente agregado correctamente.");
            LimpiarCampos();
            //Usuario usuario = new Usuario();
            //usuario.Nombre = textBoxNombre.Text;
            //usuario.Email = textBoxEmail.Text;

            //usuarioService.AgregarUsuario(usuario);

            //CargarUsuarios();
            //LimpiarCampos();

            //Paciente paciente = new Paciente();

            //ValidarCampos();
            //BorrarMensajes();
            //paciente.Cedula = txtCedula.Text;
            //paciente.Nombre = txtNombre.Text;
            //paciente.Telefono = txtTelefono.Text;
            //paciente.Edad = int.Parse(txtEdad.Text);
            //paciente.Direccion = txtDireccion.Text;
            //paciente.Sexo = char.Parse(cbSexo.Text);
            //paciente.Estrato = int.Parse(cbEstrato.Text);
            //paciente.Regimen = cbRegimen.Text;
            //paciente.FechaNacimiento = DateTime.Parse(dtpFechaNacimiento.Text);
            //paciente.FechaIngreso = DateTime.Now;
            //paciente.EPS = cbEps.Text;
            //paciente.NroIngreso = int.Parse(txtNroIngreso.Text);
            //paciente.MotivoIngreso = txtMotivoIngreso.Text;
            //paciente.ResultadoRevision = txtResultadoRevision.Text;
            //paciente.TipoTratamiento = txtTipoTratamiento.Text;
            //paciente.FormaRealizacion = txtFormaRealizacion.Text;
            //paciente.Diagnostico = txtDiagnostico.Text;
            //paciente.MedicoCargo = txtMedicoCargo.Text;
            //paciente.Observaciones = txtObservaciones.Text;
            //if (paciente.FechaNacimiento >= DateTime.Now)
            //{
            //    MessageBox.Show("La Fecha de nacimiento es invalida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}
            //else
            //{
            //    registro.GuardarPaciente(paciente);

            //    MessageBox.Show("El paciente se agregó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    LimpiarCampos();
            //    txtCedula.Focus();
            //}
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

        

        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - dtpFechaNacimiento.Value.Year;
            if (fechaActual < dtpFechaNacimiento.Value.AddYears(edad)) edad--;
            txtEdad.Text = edad.ToString();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void BorrarMensajes()
        {
            errorProvider1.SetError(txtCedula, "");
            errorProvider1.SetError(txtNombre, "");
            errorProvider1.SetError(txtTelefono, "");
            errorProvider1.SetError(txtEdad, "");
            errorProvider1.SetError(txtDireccion, "");
            errorProvider1.SetError(cbSexo, "");
            errorProvider1.SetError(cbEstrato, "");
            errorProvider1.SetError(cbRegimen, "");
            errorProvider1.SetError(cbEps, "");
            errorProvider1.SetError(txtNroIngreso, "");
            errorProvider1.SetError(txtMotivoIngreso, "");
            errorProvider1.SetError(txtResultadoRevision, "");
            errorProvider1.SetError(txtTipoTratamiento, "");
            errorProvider1.SetError(txtFormaRealizacion, "");
            errorProvider1.SetError(txtDiagnostico, "");
            errorProvider1.SetError(txtMedicoCargo, "");
            errorProvider1.SetError(txtObservaciones, "");
        }

    }
}
