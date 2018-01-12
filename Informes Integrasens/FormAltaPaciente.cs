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
    public partial class FormAltaPaciente : Form
    {
        public FormAltaPaciente()
        {



            InitializeComponent();

           
        }

        private void toolStripGuardar_Click(object sender, EventArgs e)
        {
            /* Validaciones de alta */
            int dias = DateTime.Now.Date.Subtract(textFechaNacimiento.Value.Date).Days;
            bool swError = false;

            if (dias < 0)    { MessageBox.Show("La fecha de nacimiento es superior a la del dia");  }

            int años = dias / 365;

            if (años < 18 && textNifRepre.Text == "")   {  MessageBox.Show("Es obligatorio informar el Nif del representante Legal del menor"); swError = true;  }
            if (años >= 18 && textNif.Text == "") { MessageBox.Show("Es obligatorio informar el Nif"); swError = true; }
            if (textNombre.Text == "")   { MessageBox.Show("Es obligatorio informar el Nombre"); swError = true; }
            if (textApellido1.Text == "") { MessageBox.Show("Es obligatorio informar el Apellido 1"); swError = true; }
            if (textApellido2.Text == "") { MessageBox.Show("Es obligatorio informar el Apellido 2"); swError = true; }
            if (textProvincia.Text == "") { MessageBox.Show("Es obligatorio informar el Provincia"); swError = true; }
            if (textPoblacion.Text == "") { MessageBox.Show("Es obligatorio informar el Poblacion"); swError = true; }
            if (textCP.Text == "") { MessageBox.Show("Es obligatorio informar el CP"); swError = true; }
            if (textMail.Text == "") { MessageBox.Show("Es obligatorio informar el Piso"); swError = true; }
            if (textMovil.Text == "") { MessageBox.Show("Es obligatorio informar el Letra"); swError = true; }

            if (swError == false)
            {
                try
                {
                    int tlfno =0;

                    if (textTelefono.Text != "") { tlfno = Convert.ToInt32(textTelefono.Text); }

                    // Añade fila a la tabla de Pacientes
                    IntegrasensDataSetTableAdapters.PacientesTableAdapter pacientesTableAdapter = new IntegrasensDataSetTableAdapters.PacientesTableAdapter();
                    pacientesTableAdapter.Insert(
                        textNif.Text.ToUpper(),
                        textNifRepre.Text.ToUpper(),
                        textNombre.Text.ToUpper(),
                        textApellido1.Text.ToUpper(),
                        textApellido2.Text.ToUpper(),
                        Convert.ToDateTime(textFechaNacimiento.Text),
                        textNombrePadre.Text.ToUpper(),
                        textNombreMadre.Text.ToUpper(),
                        textProvincia.Text.ToUpper(),
                        textPoblacion.Text.ToUpper(),
                        Convert.ToInt16(textCP.Text),
                        textVia.Text.ToUpper(),
                        textNombreVia.Text.ToUpper(),
                        textNumero.Text.ToUpper(),
                        textPiso.Text.ToUpper(),
                        textLetra.Text.ToUpper(),
                        textPortal.Text.ToUpper(),
                        textCuentaCargo.Text.ToUpper(),
                        tlfno,
                        textMail.Text.ToLower(),
                        Convert.ToInt32(textMovil.Text),
                        DateTime.Now,
                        Convert.ToDateTime("31/12/9999"),
                        DateTime.Now,
                        "Admin");
                MessageBox.Show("Paciente insertado correctamente");
                this.Hide();              
            }
                catch (Exception)
            {
                MessageBox.Show("Error insertando en la tabla de Pacientes, revise los datos");
            }
        }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
