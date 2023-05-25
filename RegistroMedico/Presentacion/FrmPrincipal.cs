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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cerrar();
        }

        void Cerrar()
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormularioPaciente(new FrmPaciente());
            
        }

        void AbrirFormularioPaciente(FrmPaciente f)
        {
            this.Hide();
            f.ShowDialog(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormularioHistoriaClinica(new FrmHistoriaClinica());
        }

        void AbrirFormularioHistoriaClinica(FrmHistoriaClinica f)
        {
            this.Hide();
            f.ShowDialog(this);
        }
    }
}
