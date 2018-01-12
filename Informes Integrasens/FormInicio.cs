using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Informes_Integrasens
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void toolStripInformes_Click(object sender, EventArgs e)
        {
            FormInformeIntegrasens informe = new FormInformeIntegrasens();
            informe.ShowDialog();
        }

        private void toolStripPacientes_Click(object sender, EventArgs e)
        {
            FormPacientes formPacientes = new FormPacientes();
            formPacientes.ShowDialog();
        }
    }
}
