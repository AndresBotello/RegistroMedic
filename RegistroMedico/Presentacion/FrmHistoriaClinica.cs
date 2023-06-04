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

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;



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
                txtFechaNacimiento.Text = paciente.FechaNacimiento.ToString("d");
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
                MessageBox.Show("No se encontró ningún paciente con esa cédula.");
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
            txtFechaNacimiento.Text = pacienteEncontrado.FechaNacimiento.ToString("d");
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
                    registroBD.EliminarPaciente(paciente);

                    MessageBox.Show("Paciente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                registroBD.ActualizarPaciente(paciente);

                MessageBox.Show("Paciente actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtBuscar.Text = string.Empty;
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

        private void btnPdf_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));

            string PaginaHTML_Texto = Properties.Resources.plantilla.ToString();
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CEDULA", txtCedula.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@NOMBRE", txtNombre.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DIRECCION", txtDireccion.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TELEFONO", txtTelefono.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@EDAD", txtEdad.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@SEXO", txtSexo.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@ESTRATO", txtEstrato.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@REGIMEN", txtRegimen.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHANACIMIENTO", txtFechaNacimiento.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@HORAINGRESO", txtFechaIngreso.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@EPS", txtEps.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@NINGRESO", txtNroIngreso.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@MOTIVOINGRESO", txtMotivoIngreso.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@RESULTADORE", txtResultadoRevision.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TIPOTRA", txtTipoTratamiento.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FORMADEREA", txtFormaRealizacion.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DIAGNOSTICO", txtDiagnostico.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@MEDICO", txtMedicoCargo.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@OBSERVACIONES", txtObservaciones.Text);

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    //Creamos un nuevo documento y lo definimos como PDF
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));


                    //Agregamos la imagen del banner al documento
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.UPCLO, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(60, 60);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;

                    //img.SetAbsolutePosition(10,100);
                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                    pdfDoc.Add(img);


                    using (StringReader sr = new StringReader(PaginaHTML_Texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                }

            }
        }
    }
}
