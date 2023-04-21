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
    public partial class Form3 : Form
    {
        public Form3()
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
            Form4 form4 = new Form4();
            form4.AgregarElemento(comboEstrato.Text);
            form4.AgregarElemento(comboRegimen.Text);
            form4.AgregarElemento(dateTimeFecha.Text);
            form4.AgregarElemento(textProcedimiento.Text);
            form4.AgregarElemento(textFinalidad.Text);
            form4.AgregarElemento(textTipoTratamiento.Text);
            form4.AgregarElemento(textFormaRealizacion.Text);
            form4.AgregarElemento(textDiagnostico.Text);
            form4.AgregarElemento(textMedicoCargo.Text);
            form4.AgregarElemento(textObservaciones.Text);


            form4.Show();
        }
    }
}
