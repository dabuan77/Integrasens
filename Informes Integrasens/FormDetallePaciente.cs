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
    public partial class FormDetallePaciente : Form
    {
        private Paciente paciente;

        public FormDetallePaciente(Paciente pac)
        {
            paciente = pac;

            InitializeComponent();

            textNombre.Text = paciente.Nombre;
        }
    }
}
