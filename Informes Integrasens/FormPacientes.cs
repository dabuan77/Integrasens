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
    public partial class FormPacientes : Form
    {
        public FormPacientes()
        {
            InitializeComponent();
        }

        private void Pacientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'integrasensDataSet1.Pacientes' Puede moverla o quitarla según sea necesario.
            this.pacientesTableAdapter1.Fill(this.integrasensDataSet1.Pacientes);
            //TODO: esta línea de código carga datos en la tabla 'integrasensDataSet.Pacientes' Puede moverla o quitarla según sea necesario.

            try
            {
                this.pacientesTableAdapter1.Fill(this.integrasensDataSet1.Pacientes);
        }
            catch (Exception)
            {

                MessageBox.Show("Error en la apertura de base de datos, revise que no este abierta"); 
            }

}

        private void toolStripBuscar_Click(object sender, EventArgs e)
        {
            string querry = "Nombre <> ''";

            if (textBoxNombre.Text != "") { querry = querry + " AND Nombre like '" + textBoxNombre.Text.Trim().ToUpper() + "%'"; }
            if (textBoxApell1.Text != "") { querry = querry + " AND Apellido1 like '" + textBoxApell1.Text.Trim().ToUpper() + "%'"; }
            if (textBoxApell2.Text != "") { querry = querry + " AND Apellido2 like '" + textBoxApell2.Text.Trim().ToUpper() + "%'"; }
            if (textBoxMovil.Text != "") { querry = querry + " AND Movil =" + textBoxMovil.Text.Trim(); }
            if (textBoxNif.Text != "") { querry = querry + " AND Nif like '" + textBoxNif.Text.Trim().ToUpper() + "%'"; }
            if (textBoxNifRepre.Text != "") { querry = querry + " AND Nif_representante like '" + textBoxNifRepre.Text.Trim().ToUpper() + "%'"; }

            try
            {
                this.pacientesBindingSource.Filter = querry;
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la consulta realizada, revise los datos introducidos");
            }
        }

        private void toolStripAltaPaciente_Click(object sender, EventArgs e)
        {
            FormAltaPaciente formAltaPaciente = new FormAltaPaciente();
            formAltaPaciente.ShowDialog();
        }
    }
}
