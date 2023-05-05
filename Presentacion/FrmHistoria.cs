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
    public partial class FrmHistoria : Form
    {
        public FrmHistoria()
        {
            InitializeComponent();
        }

       
        
        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmHistoriaClinica form4 = new FrmHistoriaClinica();
            form4.comboEstrato.Text = comboEstrato.Text;
            form4.comboRegimen.Text = comboRegimen.Text;
            form4.textFecha.Text = dateTimeFecha.Text;
            form4.textProcedimiento.Text = textProcedimiento.Text;
            form4.textFinalidad.Text = textFinalidad.Text;
            form4.textTipoTratamiento.Text = textTipoTratamiento.Text;
            form4.textFormaRealizacion.Text = textFormaRealizacion.Text;
            form4.textDiagnostico.Text = textDiagnostico.Text;
            form4.textMedicoCargo.Text = textMedicoCargo.Text;
            form4.textObservaciones.Text = textObservaciones.Text;


            form4.Show();
        }
    }
}
