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
    public partial class FormInformeIntegrasens : Form
    {
        private FormPreguntas form7a35preg1;
        private string tipoInforme;


        public FormInformeIntegrasens()
        {
            InitializeComponent();
            comboTerapeuta.Items.Add("Ester Buzón Antón");
            comboTerapeuta.Items.Add("Marisa Buzón Antón");
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
        }

        private void buttonSiguiente_Click(object sender, EventArgs e)
        {

            
            if (textNombre.Text == "") { MessageBox.Show("Debe informar el Nombre del paciente"); } 
            else if (textApellido1.Text == "") { MessageBox.Show("Debe informar el primer apellido del paciente"); }
            else if (textApellido2.Text == "") { MessageBox.Show("Debe informar el segundo apellido del paciente"); }
            else if (textFechaNacimiento.Text == "") { MessageBox.Show("Debe informar la fecha de nacimiento del paciente"); }
            else if (comboTerapeuta.Text == "Seleccione Terapeuta") { MessageBox.Show("Debe seleccionar terapeuta que genera el informe"); }
            else if (!checkBox1.Checked && !checkBox2.Checked && !check7a35Meses.Checked) { MessageBox.Show("Seleccione una opcion de informe a generar"); }
            else
            {
                if (check7a35Meses.Checked) { tipoInforme = "7a35"; }

                Informe informe = new Informe(textNombre.Text, textApellido1.Text, textApellido2.Text, textFechaNacimiento.Text, tipoInforme, comboTerapeuta.Text);

                form7a35preg1 = new FormPreguntas(informe);
                form7a35preg1.Show();
            }
        }      
    }
}
