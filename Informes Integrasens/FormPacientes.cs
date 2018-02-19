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
        private Paciente paciente = new Paciente();

        public FormPacientes()
        {
            InitializeComponent();
        }


        private void ToolStripBuscar_Click(object sender, EventArgs e)
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
                pacientesBindingSource.Filter = querry;
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la consulta realizada, revise los datos introducidos");
                return;
            }
        }

        private void ToolStripAltaPaciente_Click(object sender, EventArgs e)
        {
            FormAltaPaciente formAltaPaciente = new FormAltaPaciente(paciente);
            formAltaPaciente.ShowDialog();

            FormDetallePaciente formDetallePaciente = new FormDetallePaciente(paciente);
            formDetallePaciente.ShowDialog();

            pacientesTableAdapter.Fill(integrasensDataSet.Pacientes);
            pacientesBindingSource.DataMember = "Pacientes";
            pacientesBindingSource.DataSource = integrasensDataSet;
            dataGridPacientes.DataSource = pacientesBindingSource;
        }



        private void FormPacientes_Load(object sender, EventArgs e)
        {
            try
            {
               pacientesTableAdapter.Fill(integrasensDataSet.Pacientes);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la apertura de base de datos, revise que no este abierta. Error:" + ex.Message);
                return;
            }

        }

        private void DataGridPacientes_DoubleClick(object sender, EventArgs e)
        {
            paciente = new Paciente(Convert.ToInt32(dataGridPacientes.CurrentRow.Cells[10].Value));
            FormDetallePaciente formDetallePaciente = new FormDetallePaciente(paciente);
            formDetallePaciente.ShowDialog();
            //FormSecundario frm = new FormSecundario(); //Instanciamos el Form que abriremos
            //frm.txtCodigo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //frm.txtProducto.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //frm.txtPrecio.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //frm.Show();  //Mostramos el Form que deseamos abrir.           
        }

        private void dataGridPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
